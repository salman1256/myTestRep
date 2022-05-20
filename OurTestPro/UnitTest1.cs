using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace OurTestPro
{
    [TestClass]
    public class UnitTest1
    {
        private const string expected = "Welcome to Jenkins GitHub Pull Example";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                OurConApp.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
