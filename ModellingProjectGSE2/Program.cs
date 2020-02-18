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
    public class Program
 
    {
        private List<Player> players;
        public static void Main(string[] args)
        {
            Menu MainMenu = new Menu();
            //Read read = new Read();

            //MainMenu.DisplayMenu("Welcome to the Redneck Bodybuilding simulator!", MainMenu.Options);
            //read.Reading("bodybuilders.xml");
            Card card = new Card();
            card.LoadFromXMLParts();
            
    
    
    
    
    
    
            /*
            List<Card> ListOfCards = new List<Card>();
            XmlSerializer deserializer = new XmlSerializer(typeof(Card));

            using (FileStream fs = File.OpenRead("bodybuilders.xml"))
            {
                
                ListOfCards = (List<Card>)deserializer.Deserialize(fs);
            }

            foreach (Card card in ListOfCards)
            {
                Console.WriteLine(card.ToString());
            }
            */


        }
    }
}
