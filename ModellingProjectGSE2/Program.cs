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
            Read read = new Read();
            //MainMenu.DisplayMenu("Welcome to the Redneck Bodybuilding simulator!", MainMenu.Options);
            
            read.LoadFromXMLParts("bodybuilders.xml");
            
            
            
            
    
    
    
    

        }
    }
}
