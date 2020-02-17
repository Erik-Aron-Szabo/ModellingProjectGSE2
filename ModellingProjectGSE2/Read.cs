using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ModellingProjectGSE2
{
    public class Read
    {
        public Read()
        {

        }
        public void Reading(string fileName)
        {
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
            }
        }
    }
}
