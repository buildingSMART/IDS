using Ids;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchemaProject.DocAutomation
{
    public partial class IdsScript
    {
        public IdsScript(string scriptingText)
        {
            var lines = scriptingText.Split(Environment.NewLine);
            if (lines.Length > 0)
                Title = lines[0];

            bool inApplicability = true;

            Regex reIfcSchemaVersions = new Regex("^IFC[IFC2X34 \\t]+$");
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrEmpty(line))
                    continue;
                if (reIfcSchemaVersions.IsMatch(line))
                    IfcVersions = line;
                else if (Enum.TryParse<ConditionalCardinality>(line, out var parsed))
                    ApplicabilityCard = parsed;
                else if (line == "Requirements:")
                    inApplicability = false;
                else if (inApplicability)
                    ApplicabilityFacetStrings.Add(line);
                else
                    RequirementFacetStrings.Add(line);
            }
        }

        public string FileName { get; internal set; }
        public string Section { get; internal set; }

        private string ToSingleString(RequirementsTypeEntity item)
        {
            StringBuilder sb = new StringBuilder(EntityPrefix);
            sb.Append(ToSingleString(item.Name));
            if (item.SubType is not null)
                sb.Append($",{ToSingleString(item.SubType)}");
            return sb.ToString();
        }

        private string ToSingleString(RequirementsTypeProperty item)
        {
            StringBuilder sb = new StringBuilder(PropertyPrefix);
            if (item.Cardinality != ConditionalCardinality.Required)
                sb.Append($"{item.Cardinality},");
            sb.Append(ToSingleString(item.PropertySet));
            sb.Append(",");
            sb.Append(ToSingleString(item.Name));
            if (item.DataType is not null)
            {
                sb.Append(",");
                sb.Append(item.DataType);
            }
            if (item.Value is not null)
            {
                sb.Append(",");
                sb.Append(ToSingleString(item.Value));
            }
            return sb.ToString();
        }

        private string ToSingleString(RequirementsTypeMaterial item)
        {
            StringBuilder sb = new StringBuilder(MaterialPrefix);
            if (item.Cardinality != ConditionalCardinality.Required)
                sb.Append($"{item.Cardinality},");
            if (item.Value is not null)
            {
                sb.Append(ToSingleString(item.Value));
            }
            return sb.ToString();
        }

        private string ToSingleString(RequirementsTypePartOf item)
        {
            StringBuilder sb = new StringBuilder(PartOfPrefix);
            if (item.Cardinality != SimpleCardinality.Required)
                sb.Append($"{item.Cardinality},");
            sb.Append(ToSingleString(item.Entity.Name));
            if (item.Entity.SubType is not null)
            {
                sb.Append(",");
                sb.Append(ToSingleString(item.Entity.SubType));
            }
            if (item.Relation is not null)
            {
                sb.Append(",");
                sb.Append(item.Relation.ToString().ToUpperInvariant());
            }
            return sb.ToString();
        }

        private string ToSingleString(RequirementsTypeClassification item)
        {
            StringBuilder sb = new StringBuilder(ClassificationPrefix);
            if (item.Cardinality != ConditionalCardinality.Required)
                sb.Append($"{item.Cardinality},");
            sb.Append($"{ToSingleString(item.System)}");
            if (item.Value != null)
                sb.Append($",{ToSingleString(item.Value)}");
            return sb.ToString();
        }

        [DebuggerDisplay("{Value}")]
        class IfcClassName 
        {
            public IfcClassName(string v)
            {
                Value = v;
            }

            public string Value { get; set; } = "";
        }

        private string ToSingleString(RequirementsTypeAttribute item)
        {
            StringBuilder sb = new StringBuilder(AttributePrefix);
            if (item.Cardinality != ConditionalCardinality.Required)
                sb.Append($"{item.Cardinality},");
            sb.Append($"{ToSingleString(item.Name)}");
            if (item.Value != null)
            {
                sb.Append($",{ToSingleString(item.Value)}");
            }
            return sb.ToString();
        }
    }
}
