using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ModellingProjectGSE2
{
    public class Card
    {
        public string _name;
        public int _weight;
        public int _pushup;
        public int _nmrOfShots;
        public List<Card> _listOfCards = new List<Card>();
        public Card(string name, int weight, int pushup, int nmrOfShots)
        {
            _name = name;
            _weight = weight;
            _pushup = pushup;
            _nmrOfShots = nmrOfShots;
        }
        public Card()
        {

        }


        /// <summary>
        /// Move these methods to a separate class (like, XmlParser)
        /// </summary>
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
        public List<Card> LoadFromXMLParts()
        {
            XElement element = XElement.Load("bodybuilders.xml");
            var partNodes = element.Elements("fighter");
            foreach (var node in partNodes) 
            {

                Card card = new Card(); 
                card._name = node.Element("name").Value;
                card._weight = Convert.ToInt32(node.Element("weight").Value);
                card._pushup = Convert.ToInt32(node.Element("pushup").Value);
                card._nmrOfShots = Convert.ToInt32(node.Element("numbersofshot").Value);
                _listOfCards.Add(card);
                //Console.WriteLine($"{card._name}, {card._weight}, {card._pushup}, {card._nmrOfShots}");
                
            }
            return _listOfCards;
        }
    }
}
