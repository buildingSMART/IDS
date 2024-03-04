using DiffMatchPatch;
using Ids;
using SchemaProject.DocAutomation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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

        internal static string WriteIds(Ids.Ids sourceIDS, bool attributeNewline = false)
        {
			var xmlSerializer = new XmlSerializer(typeof(Ids.Ids));
            if (attributeNewline) 
            {
				using var textWriter = new StringWriter();
				var xw = XmlWriter.Create(textWriter, new XmlWriterSettings() { Indent = true, NewLineOnAttributes = true });
				xmlSerializer.Serialize(xw, sourceIDS);
				return textWriter.ToString();
			}
            else
            {
                using var textWriter = new StringWriter();
                xmlSerializer.Serialize(textWriter, sourceIDS);
                textWriter.Close();
                return textWriter.ToString();
            }
		}

        internal static void WriteIds(string destinationFilename, Ids.Ids sourceIDS)
        {
            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to serialize.
            XmlSerializer serializer = new XmlSerializer(typeof(Ids.Ids));

            using TextWriter writer = new StreamWriter(destinationFilename, false);
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            // ns.Add("ids", "http://standards.buildingsmart.org/IDS");
            ns.Add("xs", "http://www.w3.org/2001/XMLSchema");
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            serializer.Serialize(writer, sourceIDS, ns);
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

		internal static string CreateDiffReportHtml(string item)
		{
            var fileToLoad = new FileInfo(item);
            var shortFileName = Path.Combine(fileToLoad.Directory.Name, fileToLoad.Name);
			var scr = IdsScript.ScriptFromIds(fileToLoad, out var loadedIDS);
			var original = IdsHelpers.WriteIds(loadedIDS, true);
			var regen = IdsHelpers.WriteIds(scr.GetIds(), true);
            var t = new StringWriter();
            scr.WriteTo(t);
            var script = t.ToString();
            string comparison = "";


			diff_match_patch dmp = new diff_match_patch();
            if (true)
            {
			    var diffs = dmp.diff_main(original, regen, false);
                dmp.diff_cleanupSemantic(diffs);
                comparison = dmp.diff_prettyHtml(diffs).Replace("&para;", "");
			}
			else
            {
				//var a = dmp.diff_linesToChars(original, regen);
    //            var lineText1 = a[0].ToString();
				//var lineText2 = a[1].ToString();
				//var lineArray = a[2];
				//var diffs = dmp.diff_main(lineText1, lineText2, false);
				//dmp.diff_charsToLines(diffs, lineArray);
			}    
            comparison = comparison.Replace("&para;", "");

            var html = htmlSource;
            html = html.Replace("%shortFileName%", shortFileName);
            html = html.Replace("%script%", script);
            html = html.Replace("%comparison%", comparison);
            return html;
		}

        const string htmlSource =
			"""
            <html>
            <head>
              <title>Comparison report for %shortFileName%</title>
            </head>

            <body>
              <h1>Comparison report for %shortFileName%</h1>
              <h2>Script</h2>
              <pre>
            ``` ids %shortFileName%
            %script%```
              </pre>
              <h2>Comparison to original IDS</h2>
              %comparison%
            </body>

            </html>
            """;

	}
}
