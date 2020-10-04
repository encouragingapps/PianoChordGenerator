using PianoChordGenerator.Domain.Enums;
using PianoChordGenerator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PianoChordGenerator.Domain
{
    public class PianoChartData
    {
        public List<PianoChartRenderModel> ChartList { get; set; }

        public PianoChartData()
        {
            ChartList = new List<PianoChartRenderModel>();
            PianoChartRenderModel ChartItem;

            #region "Variables"
            
            const int xWhiteKeyIndicatorOffset = 10;
            const int xBlackKeyIndicatorOffset = 5;
            
            //Rows
            const string yRow1ChordIndicatorWhiteKeys = "164.71861";            
            const string yRow2ChordIndicatorWhiteKeys = "350.93127";
            const string yRow3ChordIndicatorWhiteKeys = "538.43115";
            const string yRow4ChordIndicatorWhiteKeys = "725.71942";
            const string yRow5ChordIndicatorWhiteKeys = "907.92285";
            const string yRow1ChordIndicatorBlackKeys = "110.60148";
            const string yRow2ChordIndicatorBlackKeys = "296.64819";
            const string yRow3ChordIndicatorBlackKeys = "483.72449";
            const string yRow4ChordIndicatorBlackKeys = "671.22449";
            const string yRow5ChordIndicatorBlackKeys = "853.63971";

            //Columns
            const string xHeaderLeftChart = "33.550846";
            const string xHeaderRightChart = "408.3858";

            //Rows
            const string yHeaderRow1 = "47.4524";
            const string yHeaderRow2 = "233.87416";
            const string yHeaderRow3 = "421.16229";
            const string yHeaderRow4 = "608.45044";
            const string yHeaderRow5 = "790.65387";

            const string yRow1 = "61.110298";
            const string yRow2 = "247.53206";
            const string yRow3 = "434.82019";
            const string yRow4 = "622.10834";
            const string yRow5 = "804.31177";

            //Left Charts            
            const string xWhiteKey1LeftChart = "36.388744";
            string xWhiteKey1IndicatorLeftChart = (float.Parse(xWhiteKey1LeftChart)+xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey2LeftChart = "57.42458";
            string xWhiteKey2IndicatorLeftChart = (float.Parse(xWhiteKey2LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey3LeftChart = "78.460434";
            string xWhiteKey3IndicatorLeftChart = (float.Parse(xWhiteKey3LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey4LeftChart = "97.801369";
            string xWhiteKey4IndicatorLeftChart = (float.Parse(xWhiteKey4LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey5LeftChart = "118.8372";
            string xWhiteKey5IndicatorLeftChart = (float.Parse(xWhiteKey5LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey6LeftChart = "139.87306";
            string xWhiteKey6IndicatorLeftChart = (float.Parse(xWhiteKey6LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey7LeftChart = "160.90891";
            string xWhiteKey7IndicatorLeftChart = (float.Parse(xWhiteKey7LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey8LeftChart = "181.94476";
            string xWhiteKey8IndicatorLeftChart = (float.Parse(xWhiteKey8LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey9LeftChart = "202.98062";
            string xWhiteKey9IndicatorLeftChart = (float.Parse(xWhiteKey9LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey10LeftChart = "224.01642";
            string xWhiteKey10IndicatorLeftChart = (float.Parse(xWhiteKey10LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey11LeftChart = "245.05231";
            string xWhiteKey11IndicatorLeftChart = (float.Parse(xWhiteKey11LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey12LeftChart = "266.0881";
            string xWhiteKey12IndicatorLeftChart = (float.Parse(xWhiteKey12LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey13LeftChart = "287.12396";
            string xWhiteKey13IndicatorLeftChart = (float.Parse(xWhiteKey13LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey14LeftChart = "308.15982";
            string xWhiteKey14IndicatorLeftChart = (float.Parse(xWhiteKey14LeftChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xBlackKey1LeftChart = "52.424843";
            string xBlackKey1IndicatorLeftChart = (float.Parse(xBlackKey1LeftChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey2LeftChart = "71.977608";
            string xBlackKey2IndicatorLeftChart = (float.Parse(xBlackKey2LeftChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey3LeftChart = "114.13718";
            string xBlackKey3IndicatorLeftChart = (float.Parse(xBlackKey3LeftChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey4LeftChart = "135.17305";
            string xBlackKey4IndicatorLeftChart = (float.Parse(xBlackKey4LeftChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey5LeftChart = "156.20889";
            string xBlackKey5IndicatorLeftChart = (float.Parse(xBlackKey5LeftChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey6LeftChart = "198.1927";
            string xBlackKey6IndicatorLeftChart = (float.Parse(xBlackKey6LeftChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey7LeftChart = "219.22852";
            string xBlackKey7IndicatorLeftChart = (float.Parse(xBlackKey7LeftChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey8LeftChart = "261.53732";
            string xBlackKey8IndicatorLeftChart = (float.Parse(xBlackKey8LeftChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey9LeftChart = "283.543";
            string xBlackKey9IndicatorLeftChart = (float.Parse(xBlackKey9LeftChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey10LeftChart = "304.57877";
            string xBlackKey10IndicatorLeftChart = (float.Parse(xBlackKey10LeftChart) + xBlackKeyIndicatorOffset).ToString();


            ///Right Charts
            const string xWhiteKey1RightChart = "409.52878";
            string xWhiteKey1IndicatorRightChart = (float.Parse(xWhiteKey1RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey2RightChart = "430.56461";
            string xWhiteKey2IndicatorRightChart = (float.Parse(xWhiteKey2RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey3RightChart = "451.60046";
            string xWhiteKey3IndicatorRightChart = (float.Parse(xWhiteKey3RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey4RightChart = "472.63632";
            string xWhiteKey4IndicatorRightChart = (float.Parse(xWhiteKey4RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey5RightChart = "493.67215";
            string xWhiteKey5IndicatorRightChart = (float.Parse(xWhiteKey5RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey6RightChart = "514.70795";
            string xWhiteKey6IndicatorRightChart = (float.Parse(xWhiteKey6RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey7RightChart = "535.74377";
            string xWhiteKey7IndicatorRightChart = (float.Parse(xWhiteKey7RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey8RightChart = "556.7796";
            string xWhiteKey8IndicatorRightChart = (float.Parse(xWhiteKey8RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey9RightChart = "577.81549";
            string xWhiteKey9IndicatorRightChart = (float.Parse(xWhiteKey9RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey10RightChart = "598.85126";
            string xWhiteKey10IndicatorRightChart = (float.Parse(xWhiteKey10RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey11RightChart = "619.88715";
            string xWhiteKey11IndicatorRightChart = (float.Parse(xWhiteKey11RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey12RightChart = "640.92297";
            string xWhiteKey12IndicatorRightChart = (float.Parse(xWhiteKey12RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey13RightChart = "661.9588";
            string xWhiteKey13IndicatorRightChart = (float.Parse(xWhiteKey13RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xWhiteKey14RightChart = "682.99469";
            string xWhiteKey14IndicatorRightChart = (float.Parse(xWhiteKey14RightChart) + xWhiteKeyIndicatorOffset).ToString();
            const string xBlackKey1RightChart = "425.56488";
            string xBlackKey1IndicatorRightChart = (float.Parse(xBlackKey1RightChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey2RightChart = "446.81256";
            string xBlackKey2IndicatorRightChart = (float.Parse(xBlackKey2RightChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey3RightChart = "488.97214";
            string xBlackKey3IndicatorRightChart = (float.Parse(xBlackKey3RightChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey4RightChart = "510.00803";
            string xBlackKey4IndicatorRightChart = (float.Parse(xBlackKey4RightChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey5RightChart = "531.04376";
            string xBlackKey5IndicatorRightChart = (float.Parse(xBlackKey5RightChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey6RightChart = "573.02759";
            string xBlackKey6IndicatorRightChart = (float.Parse(xBlackKey6RightChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey7RightChart = "594.06335";
            string xBlackKey7IndicatorRightChart = (float.Parse(xBlackKey7RightChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey8RightChart = "636.37219";
            string xBlackKey8IndicatorRightChart = (float.Parse(xBlackKey8RightChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey9RightChart = "658.37787";
            string xBlackKey9IndicatorRightChart = (float.Parse(xBlackKey9RightChart) + xBlackKeyIndicatorOffset).ToString();
            const string xBlackKey10RightChart = "679.41364";
            string xBlackKey10IndicatorRightChart = (float.Parse(xBlackKey10RightChart) + xBlackKeyIndicatorOffset).ToString();


            #endregion



            #region "Chart 1 Left"
            //Header
            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",X = xHeaderLeftChart,Y = yHeaderRow1
            };

            ChartList.Add(ChartItem);

            
            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "1",PianoObject = PianoObjectTypeEnum.PianoKey,  
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,X = xWhiteKey1LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoKeyId = "1", PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey, X = xWhiteKey1IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart , Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart ,Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart , Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14IndicatorLeftChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1", PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10IndicatorLeftChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);


            #endregion

            #region "Chart 2 Right"           

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "1",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14IndicatorRightChart,
                Y = yRow1ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10IndicatorRightChart,
                Y = yRow1ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 3 Left"

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xWhiteKey1IndicatorLeftChart,
                Y = yHeaderRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14IndicatorLeftChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "3",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10IndicatorLeftChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 4 Right"
            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys 
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14IndicatorRightChart,
                Y = yRow2ChordIndicatorWhiteKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);



            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "4",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.Indicator,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10IndicatorRightChart,
                Y = yRow2ChordIndicatorBlackKeys
            };

            ChartList.Add(ChartItem);
            #endregion

            #region "Chart 5 Left"

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderLeftChart,
                Y = yHeaderRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "5",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 6 Right"
            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "6",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);
            #endregion

            #region "Chart 7 Left"

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderLeftChart,
                Y = yHeaderRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "7",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 8 Right"           

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "8",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 9 Left"

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderLeftChart,
                Y = yHeaderRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "9",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 10 Right"           

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoChartRenderModel
            {
                ChartId = "10",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            #endregion


        }


    }
}
