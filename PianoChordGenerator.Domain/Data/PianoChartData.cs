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


            #region "Chart 1"
            
            const String yRow1 = "61.110298";

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
                X = "36.388744", Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "57.42458",Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "78.460434",Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "97.801369",Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "118.8372",Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "139.87306",Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "160.90891",Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "181.94476", Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "202.98062", Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "224.01642", Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "245.05231", Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "266.0881", Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "287.12396",Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "308.15982", Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "52.424843", Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "71.977608",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "114.13718",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "135.17305",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "156.20889",
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "198.1927",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "219.22852",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "261.53732",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "283.543",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "304.57877",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 2"
                     

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = "408.3858",
                Y = "47.4524"
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "409.52878",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "430.56461",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "451.60046",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "472.63632",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "493.67215",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "514.70795",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "535.74377",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "556.7796",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "577.81549",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "598.85126",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "619.88715",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "640.92297",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "661.9588",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = "682.99469",
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "425.56488",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "446.81256",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "488.97214",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "510.00803",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "531.04376",
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "573.02759",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "594.06335",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "636.37219",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "658.37787",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = "679.41364",
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            #endregion

        }


    }
}
