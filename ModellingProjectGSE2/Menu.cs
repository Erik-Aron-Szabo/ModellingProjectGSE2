using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModellingProjectGSE2
{
    public class Menu
    {
        public List<string> StartOptions = new List<string> { "Start 'game'", "Exit" };

        public void DisplayMenu(string intro, List<string> options)
        {
            int i = 0;
            Console.WriteLine(intro);

            foreach (var option in options)
            {
                Console.WriteLine($"({i}) {option}");
                i++;
            }
        }

        public Menu()
        {

        }

        public void Switch(Comparer comparer, Utility util, Read read, Card card)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("(type the name with small case)");
            string ui = Console.ReadLine();
            switch (ui)
            {
                case "exit":
                    System.Environment.Exit(1);
                    break;

                case "start":
                    int numOfPlayers;
                    numOfPlayers = util.GetListOfPlayers().Count();

                    util.ElementaryDealer(numOfPlayers, read.LoadFromXMLParts());
                    break;
            }
        }




    }
}
