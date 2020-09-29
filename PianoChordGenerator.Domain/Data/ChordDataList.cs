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
            data.Add(new KeyValuePair<string, string>("none", String.Empty));
            data.Add(new KeyValuePair<string, string>("cmaj", "C Major"));
            data.Add(new KeyValuePair<string, string>("csharpmaj", "C# Major"));

            return data;
            
        }
       
    }
}
