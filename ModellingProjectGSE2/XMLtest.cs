using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ModellingProjectGSE2
{
    class XMLtest
    {
        [XmlRoot("StepList")]
        public class StepList
        {
            [XmlElement("Step")]
            public List<Step> Steps { get; set; }
        }

        public class Step
        {
            [XmlElement("name")]
            public string Name { get; set; }
            [XmlElement("weight")]
            public string Desc { get; set; }
            [XmlElement("pushup")]
            public string Pushup { get; set; }
            [XmlElement("numberofshot")]
            public string NmrOfShot { get; set; }
        }
        public XMLtest()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(StepList));
            using (FileStream fileStream = new FileStream("bodybuilders.xml", FileMode.Open))
            {
                StepList result = (StepList) serializer.Deserialize(fileStream);
            }
        }
    }
}
