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
                     
            pictureBox1.Image = draw.DrawKeyboardAndChord(pictureBox1.Height, pictureBox1.Width);
            pictureBox2.Image = pictureBox1.Image;
            pictureBox3.Image = pictureBox1.Image;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
