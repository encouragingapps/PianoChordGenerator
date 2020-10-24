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
        private PianoKeyChordSelectionModel thisChord;

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
        public string GeneratePianoChartSvgXml(List<string> chartsToGenerate)
        {

            using MemoryStream stream = new MemoryStream();         
            using XmlWriter writer = XmlWriter.Create(stream);
                        
            int ChartCounter=0;
            
            PianoChartData pianoChartData = new PianoChartData();
                        
            writer.WriteStartElement(null, "svg", "http://www.w3.org/2000/svg");
            writer.WriteAttributeString("width", "8.5in");
            writer.WriteAttributeString("height", "11in");


            foreach (string chord in chartsToGenerate)
            {
                ChartCounter++;

                //Render all of the headers first
                foreach (PianoChartRenderModel item in
                        pianoChartData.ChartList.Where(x => x.PianoObject == PianoObjectTypeEnum.HeaderText
                                                       && x.ChartId == ChartCounter.ToString()).ToList())
                {
                    CreateHeader(writer, item.GenerateHeaderFriendlyId(),
                                     chord,
                                     item.X, item.Y);
                }

                //Render all of the keys
                foreach (PianoChartRenderModel item in
                      pianoChartData.ChartList.Where(x => x.PianoObject == PianoObjectTypeEnum.PianoKey
                                                     && x.ChartId == ChartCounter.ToString()).ToList())
                {
                    CreateKey(writer,
                              item.PianoKeyType,
                              item.GeneratePianoKeyFriendlyId(),
                              item.X, item.Y);
                }


                thisChord = new PianoKeyChordSelectionModel();

                thisChord.SetChordByFullName(chord);

                int IndicatorCounter = 0;

                foreach (PianoChartRenderModel item in
                   pianoChartData.ChartList.Where(x => x.PianoObject == PianoObjectTypeEnum.Indicator
                                                  && x.ChartId == ChartCounter.ToString()).ToList())
                {

                    if(IndicatorCounter>24)
                    {
                        IndicatorCounter = 0;
                    }

                    IndicatorCounter++;

                    switch (IndicatorCounter)
                    {
                        case 1:
                            if (thisChord.IsSelectedPianoWhite1KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 2:
                            if (thisChord.IsSelectedPianoWhite2KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 3:
                            if (thisChord.IsSelectedPianoWhite3KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 4:
                            if (thisChord.IsSelectedPianoWhite4KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 5:
                            if (thisChord.IsSelectedPianoWhite5KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 6:
                            if (thisChord.IsSelectedPianoWhite6KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 7:
                            if (thisChord.IsSelectedPianoWhite7KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 8:
                            if (thisChord.IsSelectedPianoWhite8KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 9:
                            if (thisChord.IsSelectedPianoWhite9KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 10:
                            if (thisChord.IsSelectedPianoWhite10KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 11:
                            if (thisChord.IsSelectedPianoWhite11KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 12:
                            if (thisChord.IsSelectedPianoWhite12KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 13:
                            if (thisChord.IsSelectedPianoWhite13KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 14:
                            if (thisChord.IsSelectedPianoWhite14KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 15:
                            if (thisChord.IsSelectedPianoBlack1KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 16:
                            if (thisChord.IsSelectedPianoBlack2KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 17:
                            if (thisChord.IsSelectedPianoBlack3KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 18:
                            if (thisChord.IsSelectedPianoBlack4KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 19:
                            if (thisChord.IsSelectedPianoBlack5KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 20:
                            if (thisChord.IsSelectedPianoBlack6KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 21:
                            if (thisChord.IsSelectedPianoBlack7KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 22:
                            if (thisChord.IsSelectedPianoBlack8KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 23:
                            if (thisChord.IsSelectedPianoBlack9KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                        case 24:
                            if (thisChord.IsSelectedPianoBlack10KeyId)
                            {
                                CreateIndicator(writer,
                                  item.GenerateChordIndicatorFriendlyId(),
                                  item.X, item.Y);
                            }
                            break;
                    }
                }

            }

            writer.WriteEndElement();

            writer.Flush();
            stream.Position = 0;
           
            var sr = new StreamReader(stream);
            var output = sr.ReadToEnd();

            return output;
            
        }

        void CreateHeader(XmlWriter writer, string id, string msg, string x, string y)
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

        void CreateKey(XmlWriter writer, 
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

        void CreateIndicator(XmlWriter writer,
                               string id,
                               string x,
                               string y)
        {
            const string INDICATOR_STYLE = "opacity:1;fill:#808000;fill-opacity:1;stroke:#000000;stroke-width:0.78304571;stroke-miterlimit:4;stroke-dasharray:none;stroke-dashoffset:0;stroke-opacity:1";
            const string RADIUSX = "7.7355957";
            const string RADIUSY = "6.8881383";

            writer.WriteStartElement("ellipse");
            writer.WriteAttributeString("id", id);
            writer.WriteAttributeString("rx", RADIUSX);
            writer.WriteAttributeString("ry", RADIUSY);
            writer.WriteAttributeString("cx", x);
            writer.WriteAttributeString("cy", y);
            writer.WriteAttributeString("style", INDICATOR_STYLE);            
            writer.WriteEndElement();

        }

    }
}
