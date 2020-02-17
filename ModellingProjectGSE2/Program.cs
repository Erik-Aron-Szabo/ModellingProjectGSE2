using System;
using System.Collections.Generic;
using System.Text;

namespace ModellingProjectGSE2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu MainMenu = new Menu();
            Read read = new Read();

            //MainMenu.DisplayMenu("Welcome to the Redneck Bodybuilding simulator!", MainMenu.Options);
            read.Reading("bodybuilders.xml");




        }
    }
}
