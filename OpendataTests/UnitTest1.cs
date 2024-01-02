using Microsoft.VisualStudio.TestTools.UnitTesting;
using opendata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace OpendataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetNames()
        {
            DataTransportline data = new DataTransportline(new FakeRequest());
            List<string> fakeNames = data.getNames();

            Assert.AreEqual("Toto", fakeNames[0]);
        }

        [TestMethod]
        public void TestGetLines()
        {
            DataTransportline data = new DataTransportline(new FakeRequest());
            List<List<string>> fakeLines = data.getLines();

            bool isEmpty = !fakeLines[0].Any();

            Assert.IsTrue(isEmpty);
        }
    }
}
