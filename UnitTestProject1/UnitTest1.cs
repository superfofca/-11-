using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Math.Round(Math.Cos(25 * Math.PI / 180),4),
                Math.Round(ConsoleApp2.Program.Cos2(25 * Math.PI / 180), 4));
        }
    }
}
