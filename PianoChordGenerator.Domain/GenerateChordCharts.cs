using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
//https://www.c-sharpcorner.com/UploadFile/mahesh/create-xml-in-C-Sharp/
namespace PianoChordGenerator.Domain
{
    public class GenerateChordCharts
    {
        public GenerateChordCharts()
        {
            using (XmlWriter writer = XmlWriter.Create(@"C:\Temp\pianochord.xml"))
            {

               writer.WriteStartElement(null, "svg","http://www.w3.org/2000/svg" );
                writer.WriteEndElement();
                //writer.WriteElementString("title", "Graphics Programming using GDI+");
                //writer.WriteElementString("author", "Mahesh Chand");
                //writer.WriteElementString("publisher", "Addison-Wesley");

                //writer.WriteElementString("price", "64.95");

                writer.WriteEndElement();
                
                writer.Flush();
            }

            //doc.Save("C:\\Users\\ORTIZFAMILY\\Documents\\ProjectTestDataxmlTest.xml");

       //     < svg xmlns = "http://www.w3.org/2000/svg" width = "300" height = "200" >
     
       //< rect
       //id = "rect3814"
       //width = "6.6541033"
       //height = "36.330299"
       //x = "7.3248205"
       //y = "36.963078"
       //style = "fill:#ffffff;stroke:#000000;stroke-width:0.25942752;stroke-opacity:1" />


        }
        
       

    }
}
