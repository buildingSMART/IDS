using Ids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SchemaProject.Helpers
{
    internal class IdsHelpers
    {
        internal static Ids.Ids? LoadIds(FileInfo file)
        {
            var serializer = new XmlSerializer(typeof(Ids.Ids));
            using Stream reader = new FileStream(file.FullName, FileMode.Open);
            // Call the Deserialize method to restore the object's state.
            var t = serializer.Deserialize(reader) as Ids.Ids;
            return t;
        }

        private static void AddRequirement(SpecificationType spec, PropertyType p)
        {
            RequirementsTypeProperty rqp = new RequirementsTypeProperty();
            rqp.PropertySet = p.PropertySet;
            rqp.BaseName = p.BaseName;
            rqp.Cardinality = ConditionalCardinality.Required;
            spec.Requirements = new SpecificationTypeRequirements();
            spec.Requirements.Property.Add(rqp);
        }

        private static IdsValue SimpleValueFromString(string value)
        {
            IdsValue ret = new IdsValue();
            ret.SimpleValue = value;
            return ret;
        }

        internal static Ids.Ids InitIds(string title, out Ids.SpecificationType spec)
        {
            var ret = new Ids.Ids();
            ret.Info = new Ids.IdsInfo();
            ret.Info.Title = title;
            ret.Info.Description = "Generated via code automation in the Ids Repository on github.";
            spec = IdsHelpers.DefaultSpecification(ret);
            return ret;
        }

        private static SpecificationType DefaultSpecification(Ids.Ids context)
        {
            var ret = new Ids.SpecificationType();
            context.Specifications.Add(ret);
            ret.Name = context.Info.Title;
            ret.IfcVersion.Add("IFC2X3");
            ret.IfcVersion.Add("IFC4");
            return ret;
        }

        internal static void WriteIds(string filename, Ids.Ids po)
        {
            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to serialize.
            XmlSerializer serializer = new XmlSerializer(typeof(Ids.Ids));

            TextWriter writer = new StreamWriter(filename);
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            // ns.Add("ids", "http://standards.buildingsmart.org/IDS");
            ns.Add("xs", "http://www.w3.org/2001/XMLSchema");
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            serializer.Serialize(writer, po, ns);
            writer.Close();
        }

        private static Ids.SpecificationType CreateTypeSpec(string typeName, params string[] schemas)
        {
            var spec = new Ids.SpecificationType();
            if (schemas.Any())
            {
                foreach (var sch in schemas)
                {
                    spec.IfcVersion.Add(sch);
                }
            }
            else
            {
                spec.IfcVersion.Add("IFC4");
            }
            spec.Applicability = ApplicabilityType.CreateApplicabilityType(ApplicabilityType.ApplicabilityCardinality.Required);
            spec.Applicability.Entity = new Ids.EntityType() { Name = SimpleValueFromString(typeName) };
            return spec;
        }
    }
}
