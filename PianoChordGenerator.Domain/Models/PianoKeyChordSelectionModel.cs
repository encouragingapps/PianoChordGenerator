using PianoChordGenerator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PianoChordGenerator.Domain.Models
{
    public class PianoKeyChordSelectionModel 
    {
        const string Root = " - Root";
        const string First = " - 1st";
        const string Second = " - 2nd";      

        public PianoKeyChordSelectionModel(ChordsEnum chord)
        {
            SetChord(chord);
        }

        public PianoKeyChordSelectionModel()
        {

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

      
        public void SetChordByFullName(string chord)
        {

            ChordsEnum translateChordToEnum; 

            switch (chord)
            {
                case "C Major"+Root:
                    translateChordToEnum = ChordsEnum.C_Major_Root;
                    SetChord(translateChordToEnum);                    
                    break;
                case "C Major"+First:
                    translateChordToEnum = ChordsEnum.C_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "C Major" + Second:
                    translateChordToEnum = ChordsEnum.C_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "C# Major" + Root:
                case "Db Major" + Root:
                    translateChordToEnum = ChordsEnum.C_Sharp_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "C# Major" + First:
                case "Db Major" + First:
                    translateChordToEnum = ChordsEnum.C_Sharp_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "C# Major" + Second:
                case "Db Major" + Second:
                    translateChordToEnum = ChordsEnum.C_Sharp_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "D Major" + Root:
                    translateChordToEnum = ChordsEnum.D_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "D Major" + First:
                    translateChordToEnum = ChordsEnum.D_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "D Major" + Second:
                    translateChordToEnum = ChordsEnum.D_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "D# Major" + Root:
                case "Eb Major" + Root:
                    translateChordToEnum = ChordsEnum.D_Sharp_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "D# Major" + First:
                case "Eb Major" + First:
                    translateChordToEnum = ChordsEnum.D_Sharp_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "D# Major" + Second:
                case "Eb Major" + Second:
                    translateChordToEnum = ChordsEnum.D_Sharp_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "E Major" + Root:
                    translateChordToEnum = ChordsEnum.E_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "E Major" + First:
                    translateChordToEnum = ChordsEnum.E_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "E Major" + Second:
                    translateChordToEnum = ChordsEnum.E_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "F Major" + Root:
                    translateChordToEnum = ChordsEnum.F_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "F Major" + First:
                    translateChordToEnum = ChordsEnum.F_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "F Major" + Second:
                    translateChordToEnum = ChordsEnum.F_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "F# Major" + Root:
                case "Gb Major" + Root:
                    translateChordToEnum = ChordsEnum.F_Sharp_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "F# Major" + First:
                case "Gb Major" + First:
                    translateChordToEnum = ChordsEnum.F_Sharp_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "F# Major" + Second:
                case "Gb Major" + Second:
                    translateChordToEnum = ChordsEnum.F_Sharp_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "G Major" + Root:
                    translateChordToEnum = ChordsEnum.G_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "G Major" + First:
                    translateChordToEnum = ChordsEnum.G_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "G Major" + Second:
                    translateChordToEnum = ChordsEnum.G_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "G# Major" + Root:
                case "Ab Major" + Root:
                    translateChordToEnum = ChordsEnum.G_Sharp_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "G# Major" + First:
                case "Ab Major" + First:
                    translateChordToEnum = ChordsEnum.G_Sharp_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "G# Major" + Second:
                case "Ab Major" + Second:
                    translateChordToEnum = ChordsEnum.G_Sharp_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "A Major" + Root:
                    translateChordToEnum = ChordsEnum.A_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "A Major" + First:
                    translateChordToEnum = ChordsEnum.A_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "A Major" + Second:
                    translateChordToEnum = ChordsEnum.A_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "A# Major" + Root:
                case "Bb Major" + Root:
                    translateChordToEnum = ChordsEnum.A_Sharp_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "A# Major" + First:
                case "Bb Major" + First:
                    translateChordToEnum = ChordsEnum.A_Sharp_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "A# Major" + Second:
                case "Bb Major" + Second:
                    translateChordToEnum = ChordsEnum.A_Sharp_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "B Major" + Root:
                    translateChordToEnum = ChordsEnum.B_Major_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "B Major" + First:
                    translateChordToEnum = ChordsEnum.B_Major_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "B Major" + Second:
                    translateChordToEnum = ChordsEnum.B_Major_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "C Minor" + Root:
                    translateChordToEnum = ChordsEnum.C_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "C Minor" + First:
                    translateChordToEnum = ChordsEnum.C_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "C Minor" + Second:
                    translateChordToEnum = ChordsEnum.C_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "C# Minor" + Root:
                case "Db Minor" + Root:
                    translateChordToEnum = ChordsEnum.C_Sharp_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "C# Minor" + First:
                case "Db Minor" + First:
                    translateChordToEnum = ChordsEnum.C_Sharp_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "C# Minor" + Second:
                case "Db Minor" + Second:
                    translateChordToEnum = ChordsEnum.C_Sharp_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "D Minor" + Root:
                    translateChordToEnum = ChordsEnum.D_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "D Minor" + First:
                    translateChordToEnum = ChordsEnum.D_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "D Minor" + Second:
                    translateChordToEnum = ChordsEnum.D_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "D# Minor" + Root:
                case "Eb Minor" + Root:
                    translateChordToEnum = ChordsEnum.D_Sharp_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "D# Minor" + First:
                case "Eb Minor" + First:
                    translateChordToEnum = ChordsEnum.D_Sharp_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "D# Minor" + Second:
                case "Eb Minor" + Second:
                    translateChordToEnum = ChordsEnum.D_Sharp_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "E Minor" + Root:
                    translateChordToEnum = ChordsEnum.E_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "E Minor" + First:
                    translateChordToEnum = ChordsEnum.E_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "E Minor" + Second:
                    translateChordToEnum = ChordsEnum.E_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "F Minor" + Root:
                    translateChordToEnum = ChordsEnum.F_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "F Minor" + First:
                    translateChordToEnum = ChordsEnum.F_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "F Minor" + Second:
                    translateChordToEnum = ChordsEnum.F_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "F# Minor" + Root:
                case "Gb Minor" + Root:
                    translateChordToEnum = ChordsEnum.F_Sharp_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "F# Minor" + First:
                case "Gb Minor" + First:
                    translateChordToEnum = ChordsEnum.F_Sharp_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "F# Minor" + Second:
                case "Gb Minor" + Second:
                    translateChordToEnum = ChordsEnum.F_Sharp_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "G Minor" + Root:
                    translateChordToEnum = ChordsEnum.G_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "G Minor" + First:
                    translateChordToEnum = ChordsEnum.G_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "G Minor" + Second:
                    translateChordToEnum = ChordsEnum.G_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "G# Minor" + Root:
                case "Ab Minor" + Root:
                    translateChordToEnum = ChordsEnum.G_Sharp_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "G# Minor" + First:
                case "Ab Minor" + First:
                    translateChordToEnum = ChordsEnum.G_Sharp_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "G# Minor" + Second:
                case "Ab Minor" + Second:
                    translateChordToEnum = ChordsEnum.G_Sharp_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "A Minor" + Root:
                    translateChordToEnum = ChordsEnum.A_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "A Minor" + First:
                    translateChordToEnum = ChordsEnum.A_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "A Minor" + Second:
                    translateChordToEnum = ChordsEnum.A_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "A# Minor" + Root:
                case "Bb Minor" + Root:
                    translateChordToEnum = ChordsEnum.A_Sharp_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "A# Minor" + First:
                case "Bb Minor" + First:
                    translateChordToEnum = ChordsEnum.A_Sharp_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "A# Minor" + Second:
                case "Bb Minor" + Second:
                    translateChordToEnum = ChordsEnum.A_Sharp_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
                case "B Minor" + Root:
                    translateChordToEnum = ChordsEnum.B_Minor_Root;
                    SetChord(translateChordToEnum);
                    break;
                case "B Minor" + First:
                    translateChordToEnum = ChordsEnum.B_Minor_1st;
                    SetChord(translateChordToEnum);
                    break;
                case "B Minor" + Second:
                    translateChordToEnum = ChordsEnum.B_Minor_2nd;
                    SetChord(translateChordToEnum);
                    break;
            }
            
        }

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
                case ChordsEnum.C_Sharp_Minor_Root:
                case ChordsEnum.D_Flat_Minor_Root:
                    IsSelectedPianoBlack1KeyId = true;
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    break;
                case ChordsEnum.C_Sharp_Minor_1st:
                case ChordsEnum.D_Flat_Minor_1st:
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    break;
                case ChordsEnum.C_Sharp_Minor_2nd:
                case ChordsEnum.D_Flat_Minor_2nd:
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    IsSelectedPianoWhite10KeyId = true;
                    break;
                case ChordsEnum.D_Minor_Root:
                    IsSelectedPianoWhite2KeyId = true;
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    break;
                case ChordsEnum.D_Minor_1st:
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    break;
                case ChordsEnum.D_Minor_2nd:
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    IsSelectedPianoWhite11KeyId = true;
                    break;
                case ChordsEnum.D_Sharp_Minor_Root:
                case ChordsEnum.E_Flat_Minor_Root:
                    IsSelectedPianoBlack2KeyId = true;
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    break;
                case ChordsEnum.D_Sharp_Minor_1st:
                case ChordsEnum.E_Flat_Minor_1st:
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
                    break;
                case ChordsEnum.D_Sharp_Minor_2nd:
                case ChordsEnum.E_Flat_Minor_2nd:
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
                    IsSelectedPianoBlack8KeyId = true;
                    break;
                case ChordsEnum.E_Minor_Root:
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    break;
                case ChordsEnum.E_Minor_1st:
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoWhite10KeyId = true;
                    break;
                case ChordsEnum.E_Minor_2nd:
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoWhite10KeyId = true;
                    IsSelectedPianoWhite12KeyId = true;
                    break;
                case ChordsEnum.F_Minor_Root:
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    break;
                case ChordsEnum.F_Minor_1st:
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    IsSelectedPianoWhite11KeyId = true;
                    break;
                case ChordsEnum.F_Minor_2nd:
                    IsSelectedPianoWhite8KeyId = true;
                    IsSelectedPianoWhite11KeyId = true;
                    IsSelectedPianoBlack9KeyId = true;
                    break;
                case ChordsEnum.F_Sharp_Minor_Root:
                case ChordsEnum.G_Flat_Minor_Root:
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    break;
                case ChordsEnum.F_Sharp_Minor_1st:
                case ChordsEnum.G_Flat_Minor_1st:
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    IsSelectedPianoBlack8KeyId = true;
                    break;
                case ChordsEnum.F_Sharp_Minor_2nd:
                case ChordsEnum.G_Flat_Minor_2nd:
                    IsSelectedPianoBlack6KeyId = true;
                    IsSelectedPianoBlack8KeyId = true;
                    IsSelectedPianoWhite13KeyId = true;
                    break;
                case ChordsEnum.G_Minor_Root:
                    IsSelectedPianoWhite5KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    break;
                case ChordsEnum.G_Minor_1st:
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    IsSelectedPianoWhite12KeyId = true;
                    break;
                case ChordsEnum.G_Minor_2nd:
                    IsSelectedPianoWhite9KeyId = true;
                    IsSelectedPianoWhite12KeyId = true;
                    IsSelectedPianoBlack10KeyId = true;
                    break;
                case ChordsEnum.G_Sharp_Minor_Root:
                case ChordsEnum.A_Flat_Minor_Root:
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
                    break;
                case ChordsEnum.G_Sharp_Minor_1st:
                case ChordsEnum.A_Flat_Minor_1st:
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoBlack7KeyId = true;
                    IsSelectedPianoBlack9KeyId = true;
                    break;
                case ChordsEnum.G_Sharp_Minor_2nd:
                case ChordsEnum.A_Flat_Minor_2nd:
                    IsSelectedPianoBlack2KeyId = true;
                    IsSelectedPianoBlack4KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    break;
                case ChordsEnum.A_Minor_Root:
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    IsSelectedPianoWhite10KeyId = true;
                    break;
                case ChordsEnum.A_Minor_1st:
                    IsSelectedPianoWhite1KeyId = true;
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    break;
                case ChordsEnum.A_Minor_2nd:
                    IsSelectedPianoWhite3KeyId = true;
                    IsSelectedPianoWhite6KeyId = true;
                    IsSelectedPianoWhite8KeyId = true;
                    break;
                case ChordsEnum.A_Sharp_Minor_Root:
                case ChordsEnum.B_Flat_Minor_Root:
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    IsSelectedPianoWhite11KeyId = true;
                    break;
                case ChordsEnum.A_Sharp_Minor_1st:
                case ChordsEnum.B_Flat_Minor_1st:
                    IsSelectedPianoBlack1KeyId = true;
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    break;
                case ChordsEnum.A_Sharp_Minor_2nd:
                case ChordsEnum.B_Flat_Minor_2nd:
                    IsSelectedPianoWhite4KeyId = true;
                    IsSelectedPianoBlack5KeyId = true;
                    IsSelectedPianoBlack6KeyId = true;
                    break;
                case ChordsEnum.B_Minor_Root:
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
                    IsSelectedPianoBlack8KeyId = true;
                    break;
                case ChordsEnum.B_Minor_1st:
                    IsSelectedPianoWhite2KeyId = true;
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    break;
                case ChordsEnum.B_Minor_2nd:
                    IsSelectedPianoBlack3KeyId = true;
                    IsSelectedPianoWhite7KeyId = true;
                    IsSelectedPianoWhite9KeyId = true;
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

