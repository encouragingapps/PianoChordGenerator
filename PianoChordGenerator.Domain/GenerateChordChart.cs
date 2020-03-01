using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace PianoChordGenerator.Domain
{
    public class GenerateChordChart
    {
        public void GenerateChordSheet()
        {            
            //Create Root Node
            XmlDocument doc = new XmlDocument();
            XmlNode rootNode = doc.CreateElement("svg");

            //Add Root Node Attributes
            XmlAttribute dc = doc.CreateAttribute("xmlns:dc");
            dc.Value = "http://purl.org/dc/elements/1.1/";
            rootNode.Attributes.Append(dc);

            XmlAttribute cc = doc.CreateAttribute("xmlns:cc");
            cc.Value = "http://creativecommons.org/ns#";
            rootNode.Attributes.Append(cc);

            XmlAttribute rdf = doc.CreateAttribute("xmlns:rdf");
            rdf.Value = "http://www.w3.org/1999/02/22-rdf-syntax-ns#";
            rootNode.Attributes.Append(rdf);

            //Append Root Node to Document
            doc.AppendChild(rootNode);

            //XmlNode userNode = xmlDoc.CreateElement("user");
            //XmlAttribute attribute = xmlDoc.CreateAttribute("age");
            //attribute.Value = "42";
            //userNode.Attributes.Append(attribute);
            //userNode.InnerText = "John Doe";
            //rootNode.AppendChild(userNode);

            //userNode = xmlDoc.CreateElement("user");
            //attribute = xmlDoc.CreateAttribute("age");
            //attribute.Value = "39";
            //userNode.Attributes.Append(attribute);
            //userNode.InnerText = "Jane Doe";
            //rootNode.AppendChild(userNode);

            doc.Save("C:\\Users\\ORTIZFAMILY\\Documents\\ProjectTestDataxmlTest.xml");
        }
        
       

    }
}
