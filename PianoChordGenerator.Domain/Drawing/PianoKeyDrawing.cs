using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;



namespace PianoChordGenerator.Domain.Drawing
{
    public class PianoKeyDrawing
    {
        public Bitmap DrawKeyboardAndChord(int height, int width)
        {
            const int BLACK_KEY_HEIGHT = 43;
            const int BLACK_KEY_WIDTH = 15;
            const int WHITE_KEY_HEIGHT = 75;
            const int WHITE_KEY_WIDTH = 20;

            Bitmap bmp = new Bitmap(width, height);
            using Graphics g = Graphics.FromImage(bmp);
            //g.DrawLine(new Pen(Color.Red), 0, 0, 100, 100);

            // Create solid brush.
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            // Create black keys
            Rectangle blackkey1 = new Rectangle(12, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);
            Rectangle blackkey2 = new Rectangle(34, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);
            Rectangle blackkey3 = new Rectangle(72, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);
            Rectangle blackkey4 = new Rectangle(92, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);
            Rectangle blackkey5 = new Rectangle(112, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);
            Rectangle blackkey6 = new Rectangle(154, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);
            Rectangle blackkey7 = new Rectangle(174, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);
            Rectangle blackkey8 = new Rectangle(214, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);
            Rectangle blackkey9 = new Rectangle(234, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);
            Rectangle blackkey10 = new Rectangle(254, 0, BLACK_KEY_WIDTH, BLACK_KEY_HEIGHT);


            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create white keys
            Rectangle whitekey1 = new Rectangle(0, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey2 = new Rectangle(20, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey3 = new Rectangle(40, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey4 = new Rectangle(60, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey5 = new Rectangle(80, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey6 = new Rectangle(100, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey7 = new Rectangle(120, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey8 = new Rectangle(140, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey9 = new Rectangle(160, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey10 = new Rectangle(180, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey11 = new Rectangle(200, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey12 = new Rectangle(220, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey13 = new Rectangle(240, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);
            Rectangle whitekey14 = new Rectangle(260, 0, WHITE_KEY_WIDTH, WHITE_KEY_HEIGHT);

            // Draw white keys
            g.DrawRectangle(blackPen, whitekey1);
            g.DrawRectangle(blackPen, whitekey2);
            g.DrawRectangle(blackPen, whitekey3);
            g.DrawRectangle(blackPen, whitekey4);
            g.DrawRectangle(blackPen, whitekey5);
            g.DrawRectangle(blackPen, whitekey6);
            g.DrawRectangle(blackPen, whitekey7);
            g.DrawRectangle(blackPen, whitekey8);
            g.DrawRectangle(blackPen, whitekey9);
            g.DrawRectangle(blackPen, whitekey10);
            g.DrawRectangle(blackPen, whitekey11);
            g.DrawRectangle(blackPen, whitekey12);
            g.DrawRectangle(blackPen, whitekey13);
            g.DrawRectangle(blackPen, whitekey14);

            // Draw black keys
            g.FillRectangle(blackBrush, blackkey1);
            g.FillRectangle(blackBrush, blackkey2);
            g.FillRectangle(blackBrush, blackkey3);
            g.FillRectangle(blackBrush, blackkey4);
            g.FillRectangle(blackBrush, blackkey5);
            g.FillRectangle(blackBrush, blackkey6);
            g.FillRectangle(blackBrush, blackkey7);
            g.FillRectangle(blackBrush, blackkey8);
            g.FillRectangle(blackBrush, blackkey9);
            g.FillRectangle(blackBrush, blackkey10);

            return bmp;
        }
     
    }
}
