using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ModellingProjectGSE2
{

    [Serializable()]
    public class Read 
    {
        List<Card> _listOfCards = new List<Card>();
        public Read()
        {

        }

        public List<Card> LoadFromXMLParts(string fileName = "bodybuilders.xml")
        {
            XElement element = XElement.Load(fileName);
            var partNodes = element.Elements("fighter");
            foreach (var node in partNodes)
            {

                Card card = new Card();
                card._name = node.Element("name").Value;
                card._weight = Convert.ToInt32(node.Element("weight").Value);
                card._pushup = Convert.ToInt32(node.Element("pushup").Value);
                card._nmrOfShots = Convert.ToInt32(node.Element("numbersofshot").Value);
                _listOfCards.Add(card);

            }
            return _listOfCards;
        }

        
        
    }
}
