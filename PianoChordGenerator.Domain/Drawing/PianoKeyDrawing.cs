using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using PianoChordGenerator.Domain.Enums;
using PianoChordGenerator.Domain.Models;

namespace PianoChordGenerator.Domain.Drawing
{
    public class PianoKeyDrawing : IDisposable
    {

        public ChordsEnum SelectedChordEnum { get; set; }
        public bool SetNoIndicators { get; set; }
        public PianoKeyChordSelectionModel KeySelection { get; set; }

        public PianoKeyDrawing(ChordsEnum chord)
        {
            SelectedChordEnum = chord;
            KeySelection = new PianoKeyChordSelectionModel(SelectedChordEnum);
            SetNoIndicators = false;
        }

        public PianoKeyDrawing()
        {
            SetNoIndicators = true;
        }

       
        public Bitmap DrawKeyboardAndChord(int height, int width)
        {
            const int BLACK_KEY_HEIGHT = 43;
            const int BLACK_KEY_WIDTH = 15;
            const int WHITE_KEY_HEIGHT = 75;
            const int WHITE_KEY_WIDTH = 20;
            const int INDICATOR_HEIGHT = 15;
            const int INDICATOR_WIDTH = 15;

            Bitmap bmp = new Bitmap(width, height);
            using Graphics g = Graphics.FromImage(bmp);

            #region "Setup Art Tools"
                // Create solid brush.
                SolidBrush blackBrush = new SolidBrush(Color.Black);
                SolidBrush greenBrush = new SolidBrush(Color.Green);
          
                // Create pen.
                Pen blackPen = new Pen(Color.Black, 3);
            #endregion

            #region "Draw White Keys"
                // Draw white keys          
                g.DrawRectangle(blackPen, new Rectangle(0, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));                            
                g.DrawRectangle(blackPen, new Rectangle(20, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(40, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(60, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(80, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(100, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(120, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(140, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(160, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(180, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(200, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(220, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(240, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
                g.DrawRectangle(blackPen, new Rectangle(260, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT));
            #endregion

            #region "Draw Black Keys"
                // Draw black keys
                g.FillRectangle(blackBrush, new Rectangle(12, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
                g.FillRectangle(blackBrush, new Rectangle(34, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
                g.FillRectangle(blackBrush, new Rectangle(72, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
                g.FillRectangle(blackBrush, new Rectangle(92, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
                g.FillRectangle(blackBrush, new Rectangle(112, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
                g.FillRectangle(blackBrush, new Rectangle(154, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
                g.FillRectangle(blackBrush, new Rectangle(174, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
                g.FillRectangle(blackBrush, new Rectangle(214, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
                g.FillRectangle(blackBrush, new Rectangle(234, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
                g.FillRectangle(blackBrush, new Rectangle(254, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT));
            #endregion

            #region "Draw Whitekey Indicators"
                //Draw whitekey indicators
                if (KeySelection.IsSelectedPianoWhite1KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(2, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite2KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(23, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite3KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(43, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite4KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(63, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite5KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(83, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite6KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(103, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite7KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(123, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite8KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(143, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite9KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(163, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite10KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(183, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite11KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(203, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite12KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(223, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite13KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(243, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoWhite14KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(263, 50, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }
            #endregion

            #region "Draw Blackkey Indicators"
                //Draw blackey indicators
                if (KeySelection.IsSelectedPianoBlack1KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(12, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoBlack2KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(34, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoBlack3KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(72, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoBlack4KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(92, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoBlack5KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(112, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoBlack6KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(154, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoBlack7KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(174, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoBlack8KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(214, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoBlack9KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(234, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }

                if (KeySelection.IsSelectedPianoBlack10KeyId && !SetNoIndicators)
                {
                    g.FillEllipse(greenBrush, new Rectangle(254, 20, INDICATOR_WIDTH, INDICATOR_HEIGHT));
                }
            #endregion

            return bmp;
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
    }
}
