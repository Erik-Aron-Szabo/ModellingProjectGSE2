using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Linq;

namespace ModellingProjectGSE2
{
    public class Program
 
    {
        private List<Player> players;
        public static void Main(string[] args)
        {
            Comparer comparer = new Comparer(); //  Comparing cards (only 2 for now)
            Menu MainMenu = new Menu();
            Utility util = new Utility();
            Read read = new Read();
            Card card = new Card();
            //MainMenu.DisplayMenu("Welcome to the Redneck Bodybuilding simulator!", MainMenu.Options);

            int numOfPlayers;
            numOfPlayers = util.GetListOfPlayers().Count();

            util.ElementaryDealer(numOfPlayers, read.LoadFromXMLParts());
            while (true) //util.GameNotOver(List<Player> listOfPlayers)
            {
                
                //util.Round





            }








        }
    }
}
