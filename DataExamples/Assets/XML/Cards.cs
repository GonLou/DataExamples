using System.Xml;
using System.Xml.Serialization;

public class Cards {

    [XmlAttribute("Name")]
    public string name;

    [XmlElement("Faction")]
    public string faction;

    [XmlElement("Type")]
    public string type;

    [XmlElement("HowMany")]
    public int howMany;

    [XmlElement("Cost")]
    public int cost;

    [XmlElement("Attack")]
    public int attack;

    [XmlElement("Defense")]
    public int defense;

}
