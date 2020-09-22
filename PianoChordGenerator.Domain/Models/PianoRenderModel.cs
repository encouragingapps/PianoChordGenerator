using PianoChordGenerator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PianoChordGenerator.Domain.Models
{
    public class PianoRenderModel
    {
        
        public string PianoKeyId { get; set; }
        public string ChartId { get; set; }
        public PianoKeyTypeEnum PianoKeyType { get; set; }
        public PianoObjectTypeEnum PianoObject { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string HeaderText { get; set; }

        public string GeneratePianoKeyFriendlyId()
        {
            string keyType;
            string chartId;

            if(PianoKeyType==PianoKeyTypeEnum.WhiteKey)
            {
                keyType = "WhiteKey"+PianoKeyId;
            } 
            else
            {
                keyType = "BlackKey"+PianoKeyId;
            }

            chartId = "ChartID" + ChartId;

            return chartId+keyType;
        }

        public string GenerateHeaderFriendlyId()
        {
            return "ChartID"+ChartId + "Header";
        }

    }
  }

