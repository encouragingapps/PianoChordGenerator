﻿using PianoChordGenerator.Domain.Drawing;
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
