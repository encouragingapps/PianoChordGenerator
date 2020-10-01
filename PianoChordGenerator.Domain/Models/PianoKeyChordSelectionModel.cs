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
                case ChordsEnum.D_Flat_Major_Root:
                    IsSelectedPianoBlack1KeyId = true;
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    break;
                case ChordsEnum.C_Sharp_Major_1st:
                case ChordsEnum.D_Flat_Major_1st:
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    break;
                case ChordsEnum.C_Sharp_Major_2nd:
                case ChordsEnum.D_Flat_Major_2nd:
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    IsSelectedPianoWhite11KeyId = true;
                    break;           
                case ChordsEnum.D_Major_Root:
                    IsSelectedPianoWhite2KeyId = true;
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    break;
                case ChordsEnum.D_Major_1st:
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    break;
                case ChordsEnum.D_Major_2nd:
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    IsSelectedPianoBlack8KeyId = true;
                    break;
                case ChordsEnum.D_Sharp_Major_Root:
                case ChordsEnum.E_Flat_Major_Root:
                    IsSelectedPianoBlack2KeyId = true;
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    break;
                case ChordsEnum.D_Sharp_Major_1st:
                case ChordsEnum.E_Flat_Major_1st:
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
                    break;
                case ChordsEnum.D_Sharp_Major_2nd:
                case ChordsEnum.E_Flat_Major_2nd:
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
                    IsSelectedPianoWhite12KeyId = true;
                    break;
                case ChordsEnum.E_Major_Root:
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    break;
                case ChordsEnum.E_Major_1st:
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoWhite10KeyId = true;
                    break;
                case ChordsEnum.E_Major_2nd:
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoWhite10KeyId = true;
                    IsSelectedPianoBlack9KeyId = true;
                    break;
                case ChordsEnum.F_Major_Root:
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    break;
                case ChordsEnum.F_Major_1st:
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    IsSelectedPianoWhite11KeyId = true;
                    break;
                case ChordsEnum.F_Major_2nd:
                    IsSelectedPianoWhite8KeyId = true;
                    IsSelectedPianoWhite11KeyId = true;
                    IsSelectedPianoWhite13KeyId = true;
                    break;
                case ChordsEnum.F_Sharp_Major_Root:
                case ChordsEnum.G_Flat_Major_Root:
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    break;
                case ChordsEnum.F_Sharp_Major_1st:
                case ChordsEnum.G_Flat_Major_1st:
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    IsSelectedPianoBlack8KeyId = true;
                    break;
                case ChordsEnum.F_Sharp_Major_2nd:
                case ChordsEnum.G_Flat_Major_2nd:
                    IsSelectedPianoBlack6KeyId = true;
                    IsSelectedPianoBlack8KeyId = true;
                    IsSelectedPianoBlack10KeyId = true;
                    break;
                case ChordsEnum.G_Major_Root:
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    break;
                case ChordsEnum.G_Major_1st:
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    IsSelectedPianoWhite12KeyId = true;
                    break;
                case ChordsEnum.G_Major_2nd:
                    IsSelectedPianoWhite9KeyId = true;
                    IsSelectedPianoWhite12KeyId = true;
                    IsSelectedPianoWhite14KeyId = true;
                    break;
                case ChordsEnum.G_Sharp_Major_Root:
                case ChordsEnum.A_Flat_Major_Root:
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
                    break;
                case ChordsEnum.G_Sharp_Major_1st:
                case ChordsEnum.A_Flat_Major_1st:
                    IsSelectedPianoWhite1KeyId = true;
                    IsSelectedPianoBlack2KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    break;
                case ChordsEnum.G_Sharp_Major_2nd:
                case ChordsEnum.A_Flat_Major_2nd:
                    IsSelectedPianoBlack2KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    break;
                case ChordsEnum.A_Major_Root:
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    IsSelectedPianoWhite10KeyId = true;
                    break;
                case ChordsEnum.A_Major_1st:
                    IsSelectedPianoBlack1KeyId = true;
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    break;
                case ChordsEnum.A_Major_2nd:
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    break;
                case ChordsEnum.A_Sharp_Major_Root:
                case ChordsEnum.B_Flat_Major_Root:
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    IsSelectedPianoWhite11KeyId = true;
                    break;
                case ChordsEnum.A_Sharp_Major_1st:
                case ChordsEnum.B_Flat_Major_1st:
                    IsSelectedPianoWhite2KeyId = true;
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    break;
                case ChordsEnum.A_Sharp_Major_2nd:
                case ChordsEnum.B_Flat_Major_2nd:
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    break;
                case ChordsEnum.B_Major_Root:
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
                    IsSelectedPianoBlack8KeyId = true;
                    break;
                case ChordsEnum.B_Major_1st:
                    IsSelectedPianoBlack2KeyId = true;
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    break;
                case ChordsEnum.B_Major_2nd:
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
                    break;
                case ChordsEnum.C_Minor_Root:
                    IsSelectedPianoWhite1KeyId = true;
                    IsSelectedPianoBlack2KeyId = true;
                    IsSelectedPianoWhite5KeyId = true;
                    break;
                case ChordsEnum.C_Minor_1st:
                    IsSelectedPianoBlack2KeyId = true;
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    break;
                case ChordsEnum.C_Minor_2nd:
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
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

