using PianoChordGenerator.Domain.Drawing;
using PianoChordGenerator.Domain.Logic;
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
        private Logic logic = new Logic();

        public frmPianoChordGenerator()
        {
            InitializeComponent();

            PopulateDropDownLists();

            PianoKeyDrawing draw = new PianoKeyDrawing(Domain.Enums.ChordsEnum.C_Major_Root);
                     
            pictureBox1.Image = draw.DrawKeyboardAndChord(pictureBox1.Height, pictureBox1.Width);
            pictureBox2.Image = pictureBox1.Image;
            pictureBox3.Image = pictureBox1.Image;

        }

        private void PopulateDropDownLists()
        {
            // Clear the combobox
            cboChordSelect.DataSource = null;
            cboChordSelect.Items.Clear();

            // Bind the combobox
            cboChordSelect.DataSource = new BindingSource(logic.GetListOfChords(), null);
            cboChordSelect.DisplayMember = "Value";
            cboChordSelect.ValueMember = "Key";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
