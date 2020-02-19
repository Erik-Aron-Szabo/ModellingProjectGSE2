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
       
    }
}
