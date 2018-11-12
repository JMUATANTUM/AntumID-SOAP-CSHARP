using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace OpenAntumIDForDotNet
{
    [XmlRoot(ElementName = "ResponseAntumID")]
    public class ResponseOpenAntumID
    {
        [XmlElement(ElementName = "TAG")]
        public string TAG { get; set; }
        [XmlElement(ElementName = "RESPONSE")]
        public string RESPONSE { get; set; }
        [XmlElement(ElementName = "Element_ANTUMID")]
        public string Element_ANTUMID { get; set; }
        [XmlElement(ElementName = "Element_ISNOTBASEDONEID")]
        public string Element_ISNOTBASEDONEID { get; set; }
        [XmlElement(ElementName = "Element_GENDER")]
        public string Element_GENDER { get; set; }
        [XmlElement(ElementName = "Element_FIRSTNAME")]
        public string Element_FIRSTNAME { get; set; }
        [XmlElement(ElementName = "Element_LASTNAME")]
        public string Element_LASTNAME { get; set; }
        [XmlElement(ElementName = "Element_ADDRESS")]
        public string Element_ADDRESS { get; set; }
        [XmlElement(ElementName = "Element_CITY")]
        public string Element_CITY { get; set; }
        [XmlElement(ElementName = "Element_POSTAL")]
        public string Element_POSTAL { get; set; }
        [XmlElement(ElementName = "Element_NATIONALITY")]
        public string Element_NATIONALITY { get; set; }
        [XmlElement(ElementName = "Element_BirthDay")]
        public string Element_BirthDay { get; set; }
        [XmlElement(ElementName = "Element_BirthPlace")]
        public string Element_BirthPlace { get; set; }
        [XmlElement(ElementName = "Element_CalculatedAge")]
        public string Element_CalculatedAge { get; set; }
        [XmlElement(ElementName = "Element_LastUpdate")]
        public string Element_LastUpdate { get; set; }
        [XmlElement(ElementName = "Element_eIDValidFrom")]
        public string Element_eIDValidFrom { get; set; }
        [XmlElement(ElementName = "Element_eIDValidUntil")]
        public string Element_eIDValidUntil { get; set; }
        [XmlElement(ElementName = "Element_Email")]
        public string Element_Email { get; set; }
        [XmlElement(ElementName = "DIGIID")]
        public string DIGIID { get; set; }
    }

}
