using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using PianoChordGenerator.Domain.Enums;
//https://www.c-sharpcorner.com/UploadFile/mahesh/create-xml-in-C-Sharp/

namespace PianoChordGenerator.Domain
{
    public class GenerateChordCharts
    {
       
        public GenerateChordCharts()
        {
           
            string pathname = @"C:\Temp\"+Guid.NewGuid().ToString()+"pianochord.svg";

            using (XmlWriter writer = XmlWriter.Create(pathname))
            {

                writer.WriteStartElement(null, "svg", "http://www.w3.org/2000/svg");
                writer.WriteAttributeString("width", "8.5in");
                writer.WriteAttributeString("height", "11in");

                const String y = "36.963078";
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey1", "7.3248205", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey2", "13.978922", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey3", "12.397395", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey4", "20.633028", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey5", "20.633028", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey1", "19.118507", y);
                

                writer.WriteEndElement();

                writer.Flush();
            }

        }

        private void CreateKey(XmlWriter writer, 
                               PianoKeyTypeEnum keytype,
                               string id, 
                               string x, 
                               string y)
        {
            const String KEY_WHITE_WIDTH = "6.6541033";
            const String KEY_WHITE_HEIGHT = "36.330299";
            const String KEY_WHITE_STYLE = "fill:#ffffff;stroke:#000000;stroke-width:0.25942752;stroke-opacity:1";
            const String KEY_BLACK_WIDTH = "3.0012417";
            const String KEY_BLACK_HEIGHT = "20.712553";
            const String KEY_BLACK_STYLE = "fill:#000000;fill-opacity:1;stroke:#000000;stroke-width:0.26192313;stroke-opacity:1";

            writer.WriteStartElement("rect");
            writer.WriteAttributeString("id", id);

            if(keytype==PianoKeyTypeEnum.WhiteKey)
            {
                writer.WriteAttributeString("width", KEY_WHITE_WIDTH);
                writer.WriteAttributeString("height", KEY_WHITE_HEIGHT);                
                writer.WriteAttributeString("style", KEY_WHITE_STYLE);
            } else
            {
                writer.WriteAttributeString("width", KEY_BLACK_WIDTH);
                writer.WriteAttributeString("height", KEY_BLACK_HEIGHT);
                writer.WriteAttributeString("style", KEY_BLACK_STYLE);
            }

            writer.WriteAttributeString("x", x);
            writer.WriteAttributeString("y", y);

            writer.WriteEndElement();
        }
        
       

    }
}
