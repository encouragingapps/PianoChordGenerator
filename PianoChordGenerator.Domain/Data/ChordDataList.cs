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
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();

            // Add data to the List
            data.Add(new KeyValuePair<string, string>("maj", "Major Chords"));
            data.Add(new KeyValuePair<string, string>("cmaj", "C Major"));
            data.Add(new KeyValuePair<string, string>("csharpmaj", "C# Major"));            
            data.Add(new KeyValuePair<string, string>("dflatmaj", "Db Major"));
            data.Add(new KeyValuePair<string, string>("dmaj", "D Major"));
            data.Add(new KeyValuePair<string, string>("dsharpmaj", "D# Major"));
            data.Add(new KeyValuePair<string, string>("eflatmaj", "Eb Major"));
            data.Add(new KeyValuePair<string, string>("emaj", "E Major"));
            data.Add(new KeyValuePair<string, string>("fmaj", "F Major"));
            data.Add(new KeyValuePair<string, string>("fsharpmaj", "F# Major"));
            data.Add(new KeyValuePair<string, string>("gflatmaj", "Gb Major"));
            data.Add(new KeyValuePair<string, string>("gmaj", "G Major"));
            data.Add(new KeyValuePair<string, string>("gsharpmaj", "G# Major"));
            data.Add(new KeyValuePair<string, string>("aflatmaj", "Ab Major"));
            data.Add(new KeyValuePair<string, string>("amaj", "A Major"));
            data.Add(new KeyValuePair<string, string>("asharpmaj", "A# Major"));
            data.Add(new KeyValuePair<string, string>("bflatmaj", "Bb Major"));
            data.Add(new KeyValuePair<string, string>("bmaj", "B Major"));
            data.Add(new KeyValuePair<string, string>("min", "Minor Chords"));
            data.Add(new KeyValuePair<string, string>("cmin", "C Minor"));


            return data;
            
        }
       
    }
}
