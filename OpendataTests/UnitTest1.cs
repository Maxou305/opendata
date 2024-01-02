using Microsoft.VisualStudio.TestTools.UnitTesting;
using opendata;
using System;
using System.Collections.Generic;
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
    }
}
