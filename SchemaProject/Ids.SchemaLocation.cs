using SchemaProject.Helpers;
using System.Xml.Serialization;

namespace Ids;

// this adds the required schema location to the IDS entity
public partial class Ids
{
	[XmlAttributeAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
	public string xsiSchemaLocation = "http://standards.buildingsmart.org/IDS http://standards.buildingsmart.org/IDS/0.9.7/ids.xsd";

	

}

