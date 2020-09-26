using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;



namespace PianoChordGenerator.Domain.Drawing
{
    public class PianoKeyDrawing
    {
        public Bitmap DrawChord(int height, int width)
        {
           Bitmap bmp = new Bitmap(width, height);
            using Graphics g = Graphics.FromImage(bmp);
            //g.DrawLine(new Pen(Color.Red), 0, 0, 100, 100);

            // Create solid brush.
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            // Create rectangle.
            Rectangle blackkey1 = new Rectangle(12, 0, 15, 43);

            // Fill rectangle to screen.
            

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle.
            Rectangle whitekey1 = new Rectangle(0, 0, 20, 75);
            Rectangle whitekey2 = new Rectangle(20, 0, 20, 75);
            Rectangle whitekey3 = new Rectangle(40, 0, 20, 75);
            Rectangle whitekey4 = new Rectangle(60, 0, 20, 75);
            Rectangle whitekey5 = new Rectangle(80, 0, 20, 75);
            Rectangle whitekey6 = new Rectangle(100, 0, 20, 75);
            Rectangle whitekey7 = new Rectangle(120, 0, 20, 75);
            Rectangle whitekey8 = new Rectangle(140, 0, 20, 75);
            Rectangle whitekey9 = new Rectangle(160, 0, 20, 75);
            Rectangle whitekey10 = new Rectangle(180, 0, 20, 75);

            // Draw rectangle to screen.
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
            g.FillRectangle(blackBrush, blackkey1);



            return bmp;
        }
     
    }
}
