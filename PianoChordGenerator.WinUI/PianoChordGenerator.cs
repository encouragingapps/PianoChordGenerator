using PianoChordGenerator.Domain.Drawing;
using PianoChordGenerator.Domain.Logic;
using PianoChordGenerator.Domain.Enums;
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
        private PianoKeyDrawing draw = new PianoKeyDrawing();
        private const int IMAGE_HEIGHT = 108;
        private const int IMAGE_WIDTH = 302;

        public frmPianoChordGenerator()
        {
            InitializeComponent();

            InitializeForm();
            

        }

        #region "Load Form"
        private void InitializeForm()
        {
            PopulateDropDownLists();
            ClearIndicators();
        }
        
        private void ClearIndicators()
        {
            picRootPosition.Image = draw.DrawKeyboardAndChord(ChordsEnum.None, true,
                                                          IMAGE_HEIGHT,
                                                          IMAGE_WIDTH);

            picFirstInversion.Image = picRootPosition.Image;
            picSecondInversion.Image = picRootPosition.Image;
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
        #endregion


        private void cboChordSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            EvaluateChordSelection(cboChordSelect.SelectedValue.ToString());
        }

        private void EvaluateChordSelection(string SelectedChordValue)
        {
            switch (SelectedChordValue)
            {
                case "none":
                    ClearIndicators();
                    break;
                case "cmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.C_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.C_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.C_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));

                    break;
                case "csharpmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.C_Sharp_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.C_Sharp_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.C_Sharp_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "cmin":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.C_Minor_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.C_Minor_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.C_Minor_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "dflatmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.D_Flat_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.D_Flat_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.D_Flat_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "dmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.D_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.D_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.D_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));

                    break;
                case "dsharpmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.D_Sharp_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.D_Sharp_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.D_Sharp_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "eflatmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.E_Flat_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.E_Flat_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.E_Flat_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "emaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.E_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.E_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.E_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "fmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.F_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.F_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.F_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "fsharpmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.F_Sharp_Major_Root, false,
                                 IMAGE_HEIGHT,
                                 IMAGE_WIDTH),
                                 draw.DrawKeyboardAndChord(ChordsEnum.F_Sharp_Major_1st, false,
                                 IMAGE_HEIGHT,
                                 IMAGE_WIDTH),
                                 draw.DrawKeyboardAndChord(ChordsEnum.F_Sharp_Major_2nd, false,
                                 IMAGE_HEIGHT,
                                 IMAGE_WIDTH));
                    break;
                case "gflatmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.G_Flat_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.G_Flat_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.G_Flat_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "gmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.G_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.G_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.G_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "gsharpmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.G_Sharp_Major_Root, false,
                                 IMAGE_HEIGHT,
                                 IMAGE_WIDTH),
                                 draw.DrawKeyboardAndChord(ChordsEnum.G_Sharp_Major_1st, false,
                                 IMAGE_HEIGHT,
                                 IMAGE_WIDTH),
                                 draw.DrawKeyboardAndChord(ChordsEnum.G_Sharp_Major_2nd, false,
                                 IMAGE_HEIGHT,
                                 IMAGE_WIDTH));
                    break;
                case "aflatmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.A_Flat_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.A_Flat_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.A_Flat_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "amaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.A_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.A_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.A_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
                case "asharpmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.A_Sharp_Major_Root, false,
                                 IMAGE_HEIGHT,
                                 IMAGE_WIDTH),
                                 draw.DrawKeyboardAndChord(ChordsEnum.A_Sharp_Major_1st, false,
                                 IMAGE_HEIGHT,
                                 IMAGE_WIDTH),
                                 draw.DrawKeyboardAndChord(ChordsEnum.A_Sharp_Major_2nd, false,
                                 IMAGE_HEIGHT,
                                 IMAGE_WIDTH));
                    break;
                case "bmaj":
                    SetChordImages(draw.DrawKeyboardAndChord(ChordsEnum.B_Major_Root, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.B_Major_1st, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH),
                                   draw.DrawKeyboardAndChord(ChordsEnum.B_Major_2nd, false,
                                   IMAGE_HEIGHT,
                                   IMAGE_WIDTH));
                    break;
            }
        }

        private void SetChordImages(Bitmap RootChord, Bitmap FirstInversion, Bitmap SecondInversion)
        {
            picRootPosition.Image = RootChord;
            picFirstInversion.Image = FirstInversion;
            picSecondInversion.Image = SecondInversion;
        }

    }
}
