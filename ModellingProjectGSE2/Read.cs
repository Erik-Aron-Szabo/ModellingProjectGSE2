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

        
        public void SaveToXMLParts()
        {
            XElement root = new XElement("Cards"); // creating the root for the car object

            foreach (Card card in _listOfCards) // iterating through the car objects
            {
                root.Add( // building the tree of the car DOM
                    new XElement("Card",
                        new XElement("Name", card._name),
                        new XElement("Weight", card._weight),
                        new XElement("Pushup", card._pushup),
                        new XElement("NumberOfShots", card._nmrOfShots)
                        ));
            }

            root.Save("bodybuilders2.xml"); //saving to my documents
        }
        public void LoadFromXMLParts(string fileName)
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
                Console.WriteLine($"{card._name}, {card._weight}, {card._pushup}, {card._nmrOfShots}");

            }
        }

        public void Reading()
        {
            /*
            XDocument doc = XDocument.Load(fileName);

            foreach (XElement el in doc.Root.Elements())
            {
                Console.WriteLine("{0} {1}", el.Name, el.Attribute("id").Value);
                //Console.WriteLine("  Attributes:");
                foreach (XAttribute attr in el.Attributes())
                    Console.WriteLine("    {0}", attr);
                //Console.WriteLine("  Elements:");

                foreach (XElement element in el.Elements())
                    Console.WriteLine("    {0}: {1}", element.Name, element.Value);
            }*/
            
            


             
        }
        
    }
}
