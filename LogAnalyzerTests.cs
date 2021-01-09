using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("plikozlymrozszerzeniu.foo");

            Assert.False(result);
        }

  
        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("plikozlymrozszerzeniu.foo", false)]
        public void IsValidLogFileName_VariousExtensions_ChecksThem(string fileName, bool expected)
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(fileName);

            Assert.AreEqual(result, expected);
        }
    }
}
