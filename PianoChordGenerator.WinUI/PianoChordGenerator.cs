using PianoChordGenerator.Domain.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PianoChordGenerator.WinUI
{
    public partial class frmPianoChordGenerator : Form
    {
        public frmPianoChordGenerator()
        {
            InitializeComponent();

            PianoKeyDrawing draw = new PianoKeyDrawing();
                     
            pictureBox1.Image = draw.DrawChord(pictureBox1.Height, pictureBox1.Width);

        }

      

    }
}
