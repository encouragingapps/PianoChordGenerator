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

            const string xHeaderLeftChart = "33.550846";
            const string xHeaderRightChart = "408.3858";

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
            const string xWhiteKey2LeftChart = "57.42458";
            const string xWhiteKey3LeftChart = "78.460434";
            const string xWhiteKey4LeftChart = "97.801369";
            const string xWhiteKey5LeftChart = "118.8372";
            const string xWhiteKey6LeftChart = "139.87306";
            const string xWhiteKey7LeftChart = "160.90891";
            const string xWhiteKey8LeftChart = "181.94476";
            const string xWhiteKey9LeftChart = "202.98062";
            const string xWhiteKey10LeftChart = "224.01642";
            const string xWhiteKey11LeftChart = "245.05231";
            const string xWhiteKey12LeftChart = "266.0881";
            const string xWhiteKey13LeftChart = "287.12396";
            const string xWhiteKey14LeftChart = "308.15982";
            const string xBlackKey1LeftChart = "52.424843";
            const string xBlackKey2LeftChart = "71.977608";
            const string xBlackKey3LeftChart = "114.13718";
            const string xBlackKey4LeftChart = "135.17305";
            const string xBlackKey5LeftChart = "156.20889";
            const string xBlackKey6LeftChart = "198.1927";
            const string xBlackKey7LeftChart = "219.22852";
            const string xBlackKey8LeftChart = "261.53732";
            const string xBlackKey9LeftChart = "283.543";
            const string xBlackKey10LeftChart = "304.57877";


            ///Right Charts
            const string xWhiteKey1RightChart = "409.52878";
            const string xWhiteKey2RightChart = "430.56461";
            const string xWhiteKey3RightChart = "451.60046";
            const string xWhiteKey4RightChart = "472.63632";
            const string xWhiteKey5RightChart = "493.67215";
            const string xWhiteKey6RightChart = "514.70795";
            const string xWhiteKey7RightChart = "535.74377";
            const string xWhiteKey8RightChart = "556.7796";
            const string xWhiteKey9RightChart = "577.81549";
            const string xWhiteKey10RightChart = "598.85126";
            const string xWhiteKey11RightChart = "619.88715";
            const string xWhiteKey12RightChart = "640.92297";
            const string xWhiteKey13RightChart = "661.9588";
            const string xWhiteKey14RightChart = "682.99469";
            const string xBlackKey1RightChart = "425.56488";
            const string xBlackKey2RightChart = "446.81256";
            const string xBlackKey3RightChart = "488.97214";
            const string xBlackKey4RightChart = "510.00803";
            const string xBlackKey5RightChart = "531.04376";
            const string xBlackKey6RightChart = "573.02759";
            const string xBlackKey7RightChart = "594.06335";
            const string xBlackKey8RightChart = "636.37219";
            const string xBlackKey9RightChart = "658.37787";
            const string xBlackKey10RightChart = "679.41364";



            #region "Chart 1 Left"

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderLeftChart,
                Y = yHeaderRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,  
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart , Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart ,Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart , Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart, Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1", PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "1",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10LeftChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 2 Right"           

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10RightChart,
                Y = yRow1
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 3 Left"

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderLeftChart,
                Y = yHeaderRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "3",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10LeftChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            #endregion

            #region "Chart 4 Right"
            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "2",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "4",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey10RightChart,
                Y = yRow2
            };

            ChartList.Add(ChartItem);
            #endregion

            #region "Chart 5 Left"

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderLeftChart,
                Y = yHeaderRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "5",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
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
            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "6",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow3
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
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

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderLeftChart,
                Y = yHeaderRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "7",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
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

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "8",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow4
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
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

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderLeftChart,
                Y = yHeaderRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "9",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9LeftChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
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

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoObject = PianoObjectTypeEnum.HeaderText,
                HeaderText = "C Root Position",
                X = xHeaderRightChart,
                Y = yHeaderRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey1RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey2RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey3RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey4RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey5RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey6RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey7RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey8RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey9RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "10",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey10RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "11",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey11RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "12",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey12RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "13",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey13RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "14",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.WhiteKey,
                X = xWhiteKey14RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "1",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey1RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "2",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey2RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "3",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey3RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "4",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey4RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "5",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey5RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);


            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "6",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey6RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "7",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey7RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "8",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey8RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
            {
                ChartId = "10",
                PianoKeyId = "9",
                PianoObject = PianoObjectTypeEnum.PianoKey,
                PianoKeyType = PianoKeyTypeEnum.BlackKey,
                X = xBlackKey9RightChart,
                Y = yRow5
            };

            ChartList.Add(ChartItem);

            ChartItem = new PianoRenderModel
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
