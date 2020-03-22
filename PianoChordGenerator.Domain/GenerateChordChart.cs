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
            ////How to remove nodes
            //XmlDocument doc = new XmlDocument();
            //doc.Load(AppDomain.CurrentDomain.BaseDirectory + "Piano_Chord.xml");

            //XmlNode nodeToDelete = doc.SelectSingleNode("/root/ellipse[@ID=path5182]");
            
            //var nsmgr = new XmlNamespaceManager(doc.NameTable);
            //nsmgr.AddNamespace("rate","");
            //var node = xmlDocument.SelectSingleNode("//rate:RateQuote", nsmgr);

            //if (nodeToDelete != null)
            //{
            //    nodeToDelete.ParentNode.RemoveChild(nodeToDelete);
            //}


            //doc.Save("C:\\Users\\ORTIZFAMILY\\Documents\\ProjectTestDataxmlTest.xml");
        }
        
       

    }
}
