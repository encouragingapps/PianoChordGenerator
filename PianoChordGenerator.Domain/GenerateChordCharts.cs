﻿using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using PianoChordGenerator.Domain.Enums;
using PianoChordGenerator.Domain.Models;
//https://www.c-sharpcorner.com/UploadFile/mahesh/create-xml-in-C-Sharp/

namespace PianoChordGenerator.Domain
{
    public class GenerateChordCharts
    {
       
        public GenerateChordCharts()
        {

            PianoChartData data = new PianoChartData();


            string pathname = @"C:\Temp\"+Guid.NewGuid().ToString()+"pianochord.svg";

            using (XmlWriter writer = XmlWriter.Create(pathname))
            {

                writer.WriteStartElement(null, "svg", "http://www.w3.org/2000/svg");
                writer.WriteAttributeString("width", "8.5in");
                writer.WriteAttributeString("height", "11in");
              
               
                //Render all of the headers first
                foreach(PianoRenderModel item in 
                        data.ChartList.Where(x => x.PianoObject == PianoObjectTypeEnum.HeaderText).ToList())
                {
                        CreateHeader(writer, item.GeneratePianoKeyFriendlyId(),
                                         item.HeaderText,
                                         item.X, item.Y);
                }

                //Render all of the keys
                foreach (PianoRenderModel item in
                      data.ChartList.Where(x => x.PianoObject == PianoObjectTypeEnum.PianoKey).ToList())
                {
                    CreateKey(writer, 
                              item.PianoKeyType, 
                              item.GeneratePianoKeyFriendlyId(),
                              item.X, item.Y);
                }


                //TODO: Add copyright

                writer.WriteEndElement();

                writer.Flush();
            }

        }
       

        private void CreateHeader(XmlWriter writer, string id, string msg, string x, string y)
        {

            const String HEADER_STYLE = "font-style:normal;font-weight:bold;font-size:20px;line-height:1.25;font-family:sans-serif;letter-spacing:0px;word-spacing:0px;fill:#000000;fill-opacity:1;stroke:none;stroke-width:0.26458332";

            //https://developer.mozilla.org/en-US/docs/Web/SVG/Element/text
            //<text x="40" y="35" class="heavy">cat</text>
            writer.WriteStartElement("text");
            writer.WriteAttributeString("id", id);
            writer.WriteAttributeString("x", x);
            writer.WriteAttributeString("y", y);
            writer.WriteAttributeString("style", HEADER_STYLE);
            writer.WriteString(msg);
            writer.WriteEndElement();
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
