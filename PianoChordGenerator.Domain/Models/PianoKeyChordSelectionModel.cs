using PianoChordGenerator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PianoChordGenerator.Domain.Models
{
    public class PianoKeyChordSelectionModel 
    {

        public PianoKeyChordSelectionModel(ChordsEnum chord)
        {
            SetChord(chord);
        }

        public bool IsSelectedPianoWhite1KeyId { get; set; }
        public bool IsSelectedPianoWhite2KeyId { get; set; }
        public bool IsSelectedPianoWhite3KeyId { get; set; }
        public bool IsSelectedPianoWhite4KeyId { get; set; }
        public bool IsSelectedPianoWhite5KeyId { get; set; }
        public bool IsSelectedPianoWhite6KeyId { get; set; }
        public bool IsSelectedPianoWhite7KeyId { get; set; }
        public bool IsSelectedPianoWhite8KeyId { get; set; }
        public bool IsSelectedPianoWhite9KeyId { get; set; }
        public bool IsSelectedPianoWhite10KeyId { get; set; }
        public bool IsSelectedPianoWhite11KeyId { get; set; }
        public bool IsSelectedPianoWhite12KeyId { get; set; }
        public bool IsSelectedPianoWhite13KeyId { get; set; }
        public bool IsSelectedPianoWhite14KeyId { get; set; }

        public bool IsSelectedPianoBlack1KeyId { get; set; }
        public bool IsSelectedPianoBlack2KeyId { get; set; }
        public bool IsSelectedPianoBlack3KeyId { get; set; }
        public bool IsSelectedPianoBlack4KeyId { get; set; }
        public bool IsSelectedPianoBlack5KeyId { get; set; }
        public bool IsSelectedPianoBlack6KeyId { get; set; }
        public bool IsSelectedPianoBlack7KeyId { get; set; }
        public bool IsSelectedPianoBlack8KeyId { get; set; }
        public bool IsSelectedPianoBlack9KeyId { get; set; }
        public bool IsSelectedPianoBlack10KeyId { get; set; }

        public void SetChord(ChordsEnum chord)
        {
            ClearKeySelection();

            switch (chord)
            {
                case ChordsEnum.C_Major_Root:
                    IsSelectedPianoWhite1KeyId = true;
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoWhite5KeyId = true;
                    break;
                case ChordsEnum.C_Major_1st:
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    break;
                case ChordsEnum.C_Major_2nd:
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    IsSelectedPianoWhite10KeyId = true;
                    break;
                case ChordsEnum.C_Sharp_Major_Root:
                    IsSelectedPianoBlack1KeyId = true;
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    break;
                case ChordsEnum.C_Sharp_Major_1st:
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    break;
                case ChordsEnum.C_Sharp_Major_2nd:
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    IsSelectedPianoWhite11KeyId = true;
                    break;
            }
        }

        public void ClearKeySelection()
        {
            //Clear indicators from white keys
            IsSelectedPianoWhite1KeyId = false;
            IsSelectedPianoWhite2KeyId = false;
            IsSelectedPianoWhite3KeyId = false;
            IsSelectedPianoWhite4KeyId = false;
            IsSelectedPianoWhite5KeyId = false;
            IsSelectedPianoWhite6KeyId = false;
            IsSelectedPianoWhite7KeyId = false;
            IsSelectedPianoWhite8KeyId = false;
            IsSelectedPianoWhite9KeyId = false;
            IsSelectedPianoWhite10KeyId = false;
            IsSelectedPianoWhite11KeyId = false;
            IsSelectedPianoWhite12KeyId = false;
            IsSelectedPianoWhite13KeyId = false;
            IsSelectedPianoWhite14KeyId = false;

            //Clear indicators from block keys
            IsSelectedPianoBlack1KeyId = false;
            IsSelectedPianoBlack2KeyId = false;
            IsSelectedPianoBlack3KeyId = false;
            IsSelectedPianoBlack4KeyId = false;
            IsSelectedPianoBlack5KeyId = false;
            IsSelectedPianoBlack6KeyId = false;
            IsSelectedPianoBlack7KeyId = false;
            IsSelectedPianoBlack8KeyId = false;
            IsSelectedPianoBlack9KeyId = false;
            IsSelectedPianoBlack10KeyId = false;

        }


}
}

