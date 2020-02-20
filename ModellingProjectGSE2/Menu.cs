using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModellingProjectGSE2
{
    public class Menu
    {
        public List<string> StartOptions = new List<string> { "start", "exit" };

        public void DisplayMenu(string intro, List<string> options)
        {
            int i = 1;
            Console.WriteLine(intro);

            foreach (var option in options)
            {
                Console.WriteLine($"{option}");
                i++;
            }
        }

        public Menu()
        {

        }

        public void Switch(Comparer comparer, Utility util, Read read, Card card)
        {
            Console.WriteLine("What would you like to do?");
            string ui = "start";//Console.ReadLine();
            switch (ui)
            {
                case "exit":
                    System.Environment.Exit(1);
                    break;

                case "start":
                    Console.Clear();
                    util.ElementaryDealer(read.LoadFromXMLParts());
                    break;
            }
        }




    }
}
