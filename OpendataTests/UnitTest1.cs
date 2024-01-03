using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using OpendataLibrary;

namespace OpendataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestData()
        {
            DataTransportline data = new DataTransportline(new FakeRequest());
            List<string> fakeNames = data.getNames();
            List<List<string>> fakeLines = data.getLines();
            int fakeLinesCount = fakeLines.Count();

            Assert.AreEqual(3, fakeLinesCount);
            Assert.IsTrue(fakeLines[0].Contains("SEM:12"));
            Assert.AreEqual("Grenoble,Champs-Elysées", fakeNames[0]);
        }


    }
}
