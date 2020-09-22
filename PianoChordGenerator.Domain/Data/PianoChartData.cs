using PianoChordGenerator.Domain.Enums;
using PianoChordGenerator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PianoChordGenerator.Domain
{
    public class PianoChartData
    {
        public List<PianoRenderModel> ChartList { get; set; }

        public PianoChartData()
        {
            ChartList = new List<PianoRenderModel>();
            PianoRenderModel ChartItem;

            const String y = "61.110298";

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = "36",Y = "47.4524"
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,  
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "36.388744", Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "57.42458",Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "78.460434",Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "97.801369",Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "118.8372",Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "139.87306",Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "160.90891",Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "181.94476", Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "202.98062", Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "224.01642", Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "245.05231", Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "266.0881", Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "287.12396",Y = y
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "308.15982", Y = y
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "52.424843", Y = y
            };

            ChartList.Add(ChartItem);

            //Black Keys            
            CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey3", "114.13718", y);
            CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey4", "135.17305", y);
            CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey5", "156.20889", y);
            CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey6", "198.1927", y);
            CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey7", "219.22852", y);
            CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey8", "261.53732", y);
            CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey9", "283.543", y);
            CreateKey(writer, PianoKeyTypeEnum.BlackKey, "Chart1BlackKey10", "304.57877", y);

        }


    }
}
