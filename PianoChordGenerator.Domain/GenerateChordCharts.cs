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

                const String y = "61.110298";
                CreateHeader("Test");
                //White Keys
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey1", "36.388744", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey2", "57.42458", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey3", "78.460434", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey4", "97.801369", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey5", "118.8372", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey6", "139.87306", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey7", "160.90891", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey8", "181.94476", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey9", "202.98062", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey10", "224.01642", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey11", "245.05231", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey12", "266.0881", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey13", "287.12396", y);
                CreateKey(writer, PianoKeyTypeEnum.WhiteKey, "Chart1WhiteKey14", "308.15982", y);
                                

                //Black Keys
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey1", "52.424843", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey2", "71.977608", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey3", "114.13718", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey4", "135.17305", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey5", "156.20889", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey6", "198.1927", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey7", "219.22852", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey8", "261.53732", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey9", "283.543", y);
                CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey10", "304.57877", y);



                writer.WriteEndElement();

                writer.Flush();
            }

        }

        private void CreateHeader(string Title)
        {
            Title = "";
            //https://developer.mozilla.org/en-US/docs/Web/SVG/Element/text
            //<text x="40" y="35" class="heavy">cat</text>
        }

        private void CreateKey(XmlWriter writer, 
                               PianoKeyTypeEnum keytype,
                               string id, 
                               string x, 
                               string y)
        {
            const String KEY_WHITE_WIDTH = "21.035841";
            const String KEY_WHITE_HEIGHT = "126.2125";
            const String KEY_WHITE_STYLE = "fill:#ffffff;stroke:#000000;stroke-width:0.25942752;stroke-opacity:1";
            const String KEY_BLACK_WIDTH = "9.4879274";
            const String KEY_BLACK_HEIGHT = "71.956001";
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
