using System;
using System.Collections.Generic;
using System.Text;

namespace PianoChordGenerator.Domain.Data
{
    /// <summary>
    /// Data used for the chord drop down list.
    /// </summary>
    public class ChordDataList
    {

        public List<KeyValuePair<string, string>> GetData()
        {
            // Create a List to store our KeyValuePairs
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>
            {

                // Add data to the List
                new KeyValuePair<string, string>("maj", "Major Chords"),
                new KeyValuePair<string, string>("cmaj", "C Major"),
                new KeyValuePair<string, string>("csharpmaj", "C# Major"),
                new KeyValuePair<string, string>("dflatmaj", "Db Major"),
                new KeyValuePair<string, string>("dmaj", "D Major"),
                new KeyValuePair<string, string>("dsharpmaj", "D# Major"),
                new KeyValuePair<string, string>("eflatmaj", "Eb Major"),
                new KeyValuePair<string, string>("emaj", "E Major"),
                new KeyValuePair<string, string>("fmaj", "F Major"),
                new KeyValuePair<string, string>("fsharpmaj", "F# Major"),
                new KeyValuePair<string, string>("gflatmaj", "Gb Major"),
                new KeyValuePair<string, string>("gmaj", "G Major"),
                new KeyValuePair<string, string>("gsharpmaj", "G# Major"),
                new KeyValuePair<string, string>("aflatmaj", "Ab Major"),
                new KeyValuePair<string, string>("amaj", "A Major"),
                new KeyValuePair<string, string>("asharpmaj", "A# Major"),
                new KeyValuePair<string, string>("bflatmaj", "Bb Major"),
                new KeyValuePair<string, string>("bmaj", "B Major"),
                new KeyValuePair<string, string>("min", "Minor Chords"),
                new KeyValuePair<string, string>("cmin", "C Minor"),
                new KeyValuePair<string, string>("csharpmin", "C# Minor"),
                new KeyValuePair<string, string>("dflatmin", "Db Minor"),
                new KeyValuePair<string, string>("dmin", "D Minor"),
                new KeyValuePair<string, string>("dsharpmin", "D# Minor"),
                new KeyValuePair<string, string>("eflatmin", "Eb Minor"),
                new KeyValuePair<string, string>("emin", "E Minor"),
                new KeyValuePair<string, string>("fmin", "F Minor"),
                new KeyValuePair<string, string>("fsharpmin", "F# Minor"),
                new KeyValuePair<string, string>("gflatmin", "Gb Minor"),
                new KeyValuePair<string, string>("gmin", "G Minor"),
                new KeyValuePair<string, string>("gsharpmin", "G# Minor"),
                new KeyValuePair<string, string>("aflatmin", "Ab Minor"),
                new KeyValuePair<string, string>("amin", "A Minor"),
                new KeyValuePair<string, string>("asharpmin", "A# Minor"),
                new KeyValuePair<string, string>("bflatmin", "Bb Minor"),
                new KeyValuePair<string, string>("bmin", "B Minor")
            };

            return data;
            
        }
       
    }
}
