using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ids
{
    [System.SerializableAttribute()]
    [XmlType("restriction", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class Restriction
    {
        [XmlAttribute("base", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public string Base { get; set; } = "xs:string";


        [System.Xml.Serialization.XmlElementAttribute("enumeration", Order = 1)]
        public System.Collections.ObjectModel.Collection<Enumeration> Enumeration { get; set; } = new();
      
        [System.Xml.Serialization.XmlElementAttribute("pattern", Order = 2)]
        public System.Collections.ObjectModel.Collection<Pattern> Pattern { get; set; } = new();

        [System.Xml.Serialization.XmlElementAttribute("minInclusive", Order = 3)]
        public System.Collections.ObjectModel.Collection<MinInclusive> MinInclusive { get; set; } = new();

        [System.Xml.Serialization.XmlElementAttribute("maxInclusive", Order = 4)]
        public System.Collections.ObjectModel.Collection<MaxInclusive> MaxInclusive { get; set; } = new();

        [System.Xml.Serialization.XmlElementAttribute("minExclusive", Order = 5)]
        public System.Collections.ObjectModel.Collection<MinExclusive> MinExclusive { get; set; } = new();

        [System.Xml.Serialization.XmlElementAttribute("maxExclusive", Order = 6)]
        public System.Collections.ObjectModel.Collection<MaxExclusive> MaxExclusive { get; set; } = new();
        
        [System.Xml.Serialization.XmlElementAttribute("length", Order = 7)]
        public System.Collections.ObjectModel.Collection<Length> Length { get; set; } = new();

        [System.Xml.Serialization.XmlElementAttribute("minLength", Order = 8)]
        public System.Collections.ObjectModel.Collection<MinLength> MinLength { get; set; } = new();

        [System.Xml.Serialization.XmlElementAttribute("maxLength", Order = 9)]
        public System.Collections.ObjectModel.Collection<MaxLength> MaxLength { get; set; } = new();

        internal static string[] Collections { get; } = new[] { "Enumeration", "Pattern", "MinInclusive", "MaxInclusive", "MinExclusive", "MaxExclusive", "Length", "MinLength", "MaxLength" };

        internal void SetValues(IEnumerable<XmlValue> values)
        {
            foreach (var item in values)
            {
                if (item is Enumeration en)
                {
                    Enumeration.Add(en);
                }
                else if (item is Pattern pat)
                {
                    Pattern.Add(pat);
                }
                else if (item is MinInclusive minI)
                {
                    MinInclusive.Add(minI);
                }
                else if (item is MaxInclusive maxI)
                {
                    MaxInclusive.Add(maxI);
                }
                else if (item is MinExclusive minE)
                {
                    MinExclusive.Add(minE);
                }
                else if (item is MaxExclusive maxE)
                {
                    MaxExclusive.Add(maxE);
                }
                else if (item is Length l)
                {
                    Length.Add(l);
                }
                else if (item is MinLength minL)
                {
                    MinLength.Add(minL);
                }
                else if (item is MaxLength maxL)
                {
                    MaxLength.Add(maxL);
                }
                else
                {

                }
            }
        }
    }

    [System.SerializableAttribute()]
    [XmlType("enumeration", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class Enumeration : XmlValue { }

    [System.SerializableAttribute()]
    [XmlType("pattern", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class Pattern : XmlValue { }

    [System.SerializableAttribute()]
    [XmlType("minInclusive", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class MinInclusive : XmlValue { }

    [System.SerializableAttribute()]
    [XmlType("maxInclusive", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class MaxInclusive : XmlValue { }

    [System.SerializableAttribute()]
    [XmlType("minExclusive", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class MinExclusive : XmlValue { }

    [System.SerializableAttribute()]
    [XmlType("maxExclusive", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class MaxExclusive : XmlValue { }

    [System.SerializableAttribute()]
    [XmlType("length", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class Length : XmlValue { }

    [System.SerializableAttribute()]
    [XmlType("minLength", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class MinLength : XmlValue { }

    [System.SerializableAttribute()]
    [XmlType("maxLength", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public partial class MaxLength : XmlValue { }

    public abstract class XmlValue
    {
        [XmlAttribute("value", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public string Value { get; set; } = string.Empty;
    }


}
