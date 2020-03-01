using Microsoft.VisualStudio.TestTools.UnitTesting;
using PianoChordGenerator.Domain;

namespace PianoChordGenerator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GenerateChordChart x = new GenerateChordChart();
            x.GenerateChordSheet();
        }
    }
}
