using Ids;
using SchemaProject.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SchemaProject.DocAutomation
{
    /// <summary>
    /// Supports generation and maintenance of IDS testcases as the standard evolves.
    /// </summary>
    public partial class IdsScript
    {
        public IdsScript()
        {

        }
        public string Title { get; set; } = "Untitled";

        private const string IfcVersionDefault = "IFC2X3 IFC4";
        public string IfcVersions { get; set; } = IfcVersionDefault;
        public ConditionalCardinality ApplicabilityCard { get; set; } = ConditionalCardinality.Required;
        List<string> ApplicabilityFacetStrings { get; set; } = new List<string>();
        List<string> RequirementFacetStrings { get; set; } = new List<string>();


        public IdsScript(Ids.Ids sourceIds)
        {
            Title = sourceIds.Info.Title ?? "Untitled";


            var firstSpec = sourceIds.Specifications.FirstOrDefault();
            if (firstSpec is null) 
                return;
            IfcVersions = string.Join(" ", firstSpec.IfcVersion);
            ApplicabilityCard = CardFrom(firstSpec.Applicability);
            foreach (var item in GetFacets(firstSpec.Applicability))
                ApplicabilityFacetStrings.Add(item);
            foreach (var item in GetReqFacets(firstSpec.Requirements))
                RequirementFacetStrings.Add(item);
        }

        private IEnumerable<string> GetReqFacets(SpecificationTypeRequirements? requirements)
        {
            if (requirements is null)
                yield break;
            foreach (var item in requirements.Entity)
                yield return ToSingleString(item);
            foreach (var item in requirements.Attribute)
                yield return ToSingleString(item);
            foreach (var item in requirements.Classification)
                yield return ToSingleString(item);
            foreach (var item in requirements.PartOf)
                yield return ToSingleString(item);
            foreach (var item in requirements.Material)
                yield return ToSingleString(item);
            foreach (var item in requirements.Property)
                yield return ToSingleString(item);
        }

      

        private ConditionalCardinality CardFrom(ApplicabilityType applicability)
        {
            if (applicability.MaxOccurs == "0")
                return ConditionalCardinality.Prohibited;
            if (applicability.MinOccurs == "0")
                return ConditionalCardinality.Optional;
            return ConditionalCardinality.Required;
        }

        private IEnumerable<string> GetFacets(ApplicabilityType applicability)
        {
            if (applicability.Entity != null)
                yield return ToSingleString(applicability.Entity);
        }

        private string ToSingleString(EntityType entity)
        {
            return $"{EntityPrefix}{ToSingleString(entity.Name)}";
        }
        

        private string ToSingleString(IdsValue name)
        {
            if (name.SimpleValue is not null)            
                return $"''{name.SimpleValue}''";
            if (name.RestrictionValue is not null)
            {
                List<string> values = new List<string>();
                if (name.RestrictionValue.Base != "xs:string")
                    values.Add(name.RestrictionValue.Base);
                values.AddRange(GetVals(name.RestrictionValue.Enumeration, "Enumeration"));
                values.AddRange(GetVals(name.RestrictionValue.Pattern, "Pattern"));
                values.AddRange(GetVals(name.RestrictionValue.MinInclusive, "MinInclusive"));
                values.AddRange(GetVals(name.RestrictionValue.MaxInclusive, "MaxInclusive"));
                values.AddRange(GetVals(name.RestrictionValue.MinExclusive, "MinExclusive"));
                values.AddRange(GetVals(name.RestrictionValue.MaxExclusive, "MaxExclusive"));
                values.AddRange(GetVals(name.RestrictionValue.Length, "Length"));
                values.AddRange(GetVals(name.RestrictionValue.MinLength, "MinLength"));
                values.AddRange(GetVals(name.RestrictionValue.MaxLength, "MaxLength"));
                return string.Join(" ", values);
            }
            return "";
        }

        private IEnumerable<string> GetVals(IEnumerable<XmlValue> enumeration, string CollectionType)
        {
            if (enumeration.Any())
                yield return $"{CollectionType}(''{string.Join("'',''", enumeration.Select(x=>x.Value))}'')";
        }

        public static IdsScript? ScriptFromIds(FileInfo item)
        {
            var ret = IdsHelpers.LoadIds(item);
            if (ret == null)
                return null;
            return new IdsScript(ret);
        }

        internal Ids.Ids GetIds()
        {
            var ret = IdsHelpers.InitIds(Title, out var spec);
            if (IfcVersions != IfcVersionDefault)
            {
                spec.IfcVersion.Clear();
                var vers = IfcVersions.Split(" ");
                foreach (var item in vers)
                {
                    spec.IfcVersion.Add(item);
                }
            }
            spec.Applicability = spec.Applicability ?? new ApplicabilityType();
            switch (ApplicabilityCard)
            {
                case ConditionalCardinality.Required:
                    spec.Applicability.MinOccurs = "1";
                    spec.Applicability.MaxOccurs = "unbounded";
                    break;
                case ConditionalCardinality.Optional:
                    spec.Applicability.MinOccurs = "0";
                    spec.Applicability.MaxOccurs = "unbounded";
                    break;
                case ConditionalCardinality.Prohibited:
                    spec.Applicability.MinOccurs = "0";
                    spec.Applicability.MaxOccurs = "0";
                    break;
            }
            foreach (var app in ApplicabilityFacetStrings)
            {
                PopulateApplicability(app, spec);
            }
            if (RequirementFacetStrings.Any())
            {
                spec.Requirements = spec.Requirements ?? new SpecificationTypeRequirements();
                foreach (var app in RequirementFacetStrings)
                {
                    PopulateRequirements(app, spec.Requirements);
                }
            }
            return ret;
        }

        private const string EntityPrefix = "Entity: ";
        private const string AttributePrefix = "Attribute: ";
        private const string PartOfPrefix = "PartOf: ";
        private const string ClassificationPrefix = "Classification: ";
        private const string MaterialPrefix = "Material: ";
        private const string PropertyPrefix = "Property: ";

        private void PopulateApplicability(string app, SpecificationType spec)
        {
            var detected = Detect(app, out IList<object> parts);
            switch (detected)
            {
                case EntityPrefix:
                    spec.Applicability.Entity = MakeEntity(parts);
                    break;
                default:
                    break;
            }
        }

        private void PopulateRequirements(string app, SpecificationTypeRequirements requirements)
        {
            var detected = Detect(app, out IList<object> parts);
            switch (detected)
            {
                case EntityPrefix:
                    requirements.Entity.Add(MakeReqEntity(parts));
                    break;
                case AttributePrefix:
                    requirements.Attribute.Add(MakeReqAttribute(parts));
                    break;
                case ClassificationPrefix:
                    requirements.Classification.Add(MakeReqClassification(parts));
                    break;
                case MaterialPrefix:
                    requirements.Material.Add(MakeReqMaterial(parts));
                    break;
                case PartOfPrefix:
                    requirements.PartOf.Add(MakeReqPartOf(parts));
                    break;
                case PropertyPrefix:
                    requirements.Property.Add(MakeReqProperty(parts));
                    break;
                default:
                    break;
            }
        }

        private RequirementsTypeProperty MakeReqProperty(IList<object> parts)
        {
            var ret = new RequirementsTypeProperty();
            if (parts.Count > 0 && parts[0] is ConditionalCardinality crd)
            {
                ret.Cardinality = crd;
                parts.RemoveAt(0);
            }

            // try get datatype
            for (int i = 0; i < parts.Count;)
            {
                if (parts[i] is IfcClassName st)
                {
                    ret.DataType = st.Value;
                    parts.RemoveAt(i);
                    continue;
                }
                i++;
            }

            if (parts.Count > 0)
                ret.PropertySet = MakeIdsValue(parts[0]);
            if (parts.Count > 1)
                ret.BaseName = MakeIdsValue(parts[1]);
            if (parts.Count > 2)
                ret.Value = MakeIdsValue(parts[2]);
            return ret;
        }

        private RequirementsTypePartOf MakeReqPartOf(IList<object> parts)
        {
            var ret = new RequirementsTypePartOf();
            if (parts.Count > 0 && parts[0] is ConditionalCardinality crd)
            {
                // optional is not available, default is required
                if (crd == ConditionalCardinality.Prohibited) 
                    ret.Cardinality = SimpleCardinality.Prohibited;
                parts.RemoveAt(0);
            }
            for (int i = 0; i < parts.Count; )
            {
                if (parts[i] is IfcClassName st)
                {
                    if (TryGetRelation(st.Value, out var rel))
                    {
                        ret.Relation = rel;
                        parts.RemoveAt(i);
                        continue;
                    }
                }
                i++;
            }
            ret.Entity = new EntityType();
            if (parts.Count > 0)
                ret.Entity.Name = MakeIdsValue(parts[0]);
            if (parts.Count > 1)
            {
                ret.Entity.PredefinedType = MakeIdsValue(parts[1]);
            }
            return ret;
        }

        public static string? GetXmlEnumAttributeValueFromEnum<TEnum>(TEnum value) where TEnum : struct, IConvertible
        {
            var enumType = typeof(TEnum);
            if (!enumType.IsEnum) 
                return null;

            var member = enumType.GetMember(value.ToString()).FirstOrDefault();
            if (member == null) 
                return null;

            var attribute = member.GetCustomAttributes(false).OfType<XmlEnumAttribute>().FirstOrDefault();
            if (attribute == null) 
                return null;
            return attribute.Name;
        }

        private static Dictionary<string, Relations>? relStrings = null;


        private static bool TryGetRelation(string st, [NotNullWhen(true)] out Relations rel)
        {
            if (relStrings == null)
            {
                relStrings = new Dictionary<string, Relations>();
                foreach (var item in Enum.GetValues<Relations>())
                {
                    var t = GetXmlEnumAttributeValueFromEnum(item);
                    if (t is null)
                        continue;
                    relStrings.Add(t, item);
                }
            }
            return relStrings.TryGetValue(st, out rel);
        }

        private RequirementsTypeMaterial MakeReqMaterial(IList<object> parts)
        {
            var ret = new RequirementsTypeMaterial();
            if (parts.Count > 0 && parts[0] is ConditionalCardinality crd)
            {
                ret.Cardinality = crd;
                parts.RemoveAt(0);
            }
            if (parts.Count > 0)
                ret.Value = MakeIdsValue(parts[0]);
            return ret;
        }

        private RequirementsTypeClassification MakeReqClassification(IList<object> parts)
        {
            var ret = new RequirementsTypeClassification();
            if (parts.Count > 0 && parts[0] is ConditionalCardinality crd)
            {
                ret.Cardinality = crd;
                parts.RemoveAt(0);
            }
            if (parts.Count > 0)
                ret.System = MakeIdsValue(parts[0]);
            if (parts.Count > 1)
                ret.Value = MakeIdsValue(parts[1]);

            return ret;
        }

        private RequirementsTypeAttribute MakeReqAttribute(IList<object> parts)
        {
            var ret = new RequirementsTypeAttribute();
            if (parts.Count > 0 && parts[0] is ConditionalCardinality crd)
            {
                ret.Cardinality = crd;
                parts.RemoveAt(0);
            }
            if (parts.Count > 0)
                ret.Name = MakeIdsValue(parts[0]);
            if (parts.Count > 1)
                ret.Value = MakeIdsValue(parts[1]);

            return ret;
        }

        private EntityType? MakeEntity(IList<object> parts)
        {
            var ret = new EntityType();
            if (parts.Count > 0)
                ret.Name = MakeIdsValue(parts[0]);
            if (parts.Count > 1)
                ret.PredefinedType = MakeIdsValue(parts[1]);
            return ret;
        }
        private RequirementsTypeEntity MakeReqEntity(IList<object> parts)
        {
            var ret = new RequirementsTypeEntity();
            if (parts.Count > 0)
                ret.Name = MakeIdsValue(parts[0]);
            if (parts.Count > 1)
                ret.PredefinedType = MakeIdsValue(parts[1]);
            return ret;
        }

        private IdsValue MakeIdsValue(object incomingValue)
        {
            if (incomingValue is string)
            {
                return new IdsValue() { SimpleValue = incomingValue as string };
            }
            if (incomingValue is IdsValue idv)
                return idv;
            return new IdsValue();
        }

        private string Detect(string app, out IList<object> parts)
        {
            var types = new[] { EntityPrefix, AttributePrefix, ClassificationPrefix, PartOfPrefix, MaterialPrefix, PropertyPrefix };
            foreach (var prefix in types)
            {
                if (app.StartsWith(prefix))
                {
                    parts = GetParts(app.Substring(prefix.Length));
                    return prefix; 
                }
            }
            parts = new List<object>();
            return "";
        }

        private IList<object> GetParts(string v)
        {
            var ret = new List<object>();   
            var regString = new Regex("^''(?<string>.*?)''(?<rest>.*)$"); // .*? question mark makes it lazy
            var cardString = new Regex("^(Required|Optional|Prohibited),(?<rest>.*)$");
            var ifcNameReg = new Regex("^IFC([A-Z]+)(?<rest>.*)$");
            while (v.Length > 0)
            {
                while (v.StartsWith(" ") || v.StartsWith("\t") || v.StartsWith(","))
                {
                    v = v.Substring(1);
                    continue;
                }
                var mIfc = ifcNameReg.Match(v);
                if (mIfc.Success)
                {
                    ret.Add(new IfcClassName($"IFC{mIfc.Groups[1]}"));
                    v = mIfc.Groups["rest"].Value;
                    continue;
                }
                var mC = cardString.Match(v);
                if (mC.Success)
                {
                    switch (mC.Groups[1].Value)
                    {
                        case "Optional":
                            ret.Add(ConditionalCardinality.Optional);
                            break;
                        case "Required":
                            ret.Add(ConditionalCardinality.Required);
                            break;
                        case "Prohibited":
                            ret.Add(ConditionalCardinality.Prohibited);
                            break;
                    }
                    v = mC.Groups["rest"].Value;
                    continue;
                }
                var mS = regString.Match(v);
                if (mS.Success)
                {
                    ret.Add(mS.Groups["string"].Value);
                    v = mS.Groups["rest"].Value;
                    continue;
                }
                if (TryGetIdsValue(v, out var idsv, out var remaining))
                {
                    ret.Add(idsv);
                    v = remaining;
                    continue;
                }
                throw new NotImplementedException();
            }
            return ret;
        }

        private bool TryGetIdsValue(string inputString, [NotNullWhen(true)] out IdsValue? idsValue, out string remainingString)
        {
            var origstring = inputString; // to help debug
            IdsValue v = new IdsValue();
            v.Restriction = new Restriction();
            string rem;
            Regex reBase = new Regex("^[ \\t]*xs:(?<type>\\w+)[ ]+");
            var bMatch = reBase.Match(inputString);  
            if (bMatch.Success)
            {
                v.Restriction.Base = $"xs:{bMatch.Groups[1]}";
                inputString = reBase.Replace(inputString, "");
            }

            foreach (var collection in Restriction.Collections)
            {
                if (TryGetCollection(inputString, collection, out var values, out rem))
                {
                    inputString = rem;
                    v.Restriction.SetValues(values);
                }
            }
            if (inputString != "")
            {
            }
            remainingString = inputString;
            idsValue = v;
            return true;
        }

        private bool TryGetCollection(string inputString, string collection, out IEnumerable<XmlValue> values, out string rem) 
        {
            inputString = inputString.Trim();

            if (inputString.Contains(collection))
            {

            }

            Regex r = new Regex($"^[ \\t]*\\b{collection}\\(''(.*?)''\\)");
            var m = r.Match(inputString);   
            if (m.Success)
            {
                rem = inputString.Substring(m.Value.Length);
                var arr = m.Groups[1].Value.Split("'',''");
                switch (collection)
                {
                    case "Enumeration":
                        values = arr.Select(x=> new Enumeration() { Value = x }).ToList();
                        return true;
                    case "Pattern":
                        values = arr.Select(x => new Pattern() { Value = x }).ToList();
                        return true;
                    case "MinInclusive":
                        values = arr.Select(x => new MinInclusive() { Value = x }).ToList();
                        return true;
                    case "MaxInclusive":
                        values = arr.Select(x => new MaxInclusive() { Value = x }).ToList();
                        return true;
                    case "MinExclusive":
                        values = arr.Select(x => new MinExclusive() { Value = x }).ToList();
                        return true;
                    case "MaxExclusive":
                        values = arr.Select(x => new MaxExclusive() { Value = x }).ToList();
                        return true;
                    case "Length":
                        values = arr.Select(x => new Length() { Value = x }).ToList();
                        return true;
                    case "MinLength":
                        values = arr.Select(x => new MinLength() { Value = x }).ToList();
                        return true;
                    case "MaxLength":
                        values = arr.Select(x => new MaxLength() { Value = x }).ToList();
                        return true;
                    default:
                        values = Enumerable.Empty<XmlValue>();
                        return true;
                }
            }
            values = Enumerable.Empty<XmlValue>();
            rem = inputString;
            return false;
        }

        internal void WriteTo(StreamWriter writer)
        {
            writer.WriteLine(Title);
            if (ApplicabilityCard != ConditionalCardinality.Required)
                writer.WriteLine(ApplicabilityCard);
            if (IfcVersions != IfcVersionDefault)
                writer.WriteLine(IfcVersions);
            foreach (var item in ApplicabilityFacetStrings)
            {
                writer.WriteLine(item);
            }
            if (RequirementFacetStrings != null)
            {
                writer.WriteLine("Requirements:");
                foreach (var item in RequirementFacetStrings)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
