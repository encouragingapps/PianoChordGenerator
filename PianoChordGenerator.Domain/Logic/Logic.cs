using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using PianoChordGenerator.Domain.Data;
using PianoChordGenerator.Domain.Enums;
using PianoChordGenerator.Domain.Models;
//https://www.c-sharpcorner.com/UploadFile/mahesh/create-xml-in-C-Sharp/

namespace PianoChordGenerator.Domain.Logic
{
    public class Logic
    {
        /// <summary>
        /// Get a list of chords needed for the select chord drop down list
        /// </summary>
        /// <returns></returns>
        public List<KeyValuePair<string, string>> GetListOfChords()   
        {
            var data = new ChordDataList();
            return data.GetData();
        }
        
        /// <summary>
        /// Generate the SVG pianochord output
        /// </summary>
        /// <param name="pianoChartData"></param>
        public void GeneratePianoChart(List<string> chartsToGenerate)
        {

            int ChartCounter=0;
            string pathname = @"C:\Temp\" + Guid.NewGuid().ToString() + "pianochord.svg";

            PianoChartData pianoChartData = new PianoChartData();


            using (XmlWriter writer = XmlWriter.Create(pathname))
            {

                writer.WriteStartElement(null, "svg", "http://www.w3.org/2000/svg");
                writer.WriteAttributeString("width", "8.5in");
                writer.WriteAttributeString("height", "11in");


                foreach (string chord in chartsToGenerate)
                {
                    ChartCounter++;

                    //Render all of the headers first
                    foreach (PianoChartRenderModel item in
                            pianoChartData.ChartList.Where(x => x.PianoObject == PianoObjectTypeEnum.HeaderText
                                                           && x.ChartId==ChartCounter.ToString()).ToList())
                    {
                        CreateHeader(writer, item.GenerateHeaderFriendlyId(),
                                         chord,
                                         item.X, item.Y);
                    }

                    //Render all of the keys
                    foreach (PianoChartRenderModel item in
                          pianoChartData.ChartList.Where(x => x.PianoObject == PianoObjectTypeEnum.PianoKey
                                                         && x.ChartId==ChartCounter.ToString()).ToList())
                    {
                        CreateKey(writer,
                                  item.PianoKeyType,
                                  item.GeneratePianoKeyFriendlyId(),
                                  item.X, item.Y);
                    }

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
