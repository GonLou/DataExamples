using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("CardCollection")]
public class CardsContainer  {

    [XmlArray("Cards")]
    [XmlArrayItem("Card")]
    public List<Cards> cards = new List<Cards>();

    public static CardsContainer Load(string path)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(CardsContainer));

        FileStream stream = new FileStream(path, FileMode.Open);

        CardsContainer cards = serializer.Deserialize(stream) as CardsContainer;

        stream.Close();

        return cards;
    }

}
