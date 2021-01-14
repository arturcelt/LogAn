using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer m_Analyzer = null;

        [SetUp]
        public void SetUp()
        {
            m_Analyzer = new LogAnalyzer();
        }


        [Test]
        public void IsValidLogFileName_ValidFileLowerCased_ReturnsTrue()
        {
            bool result = m_Analyzer.IsValidLogFileName("whatever.slf");

            Assert.IsTrue(result, "Plik powinien mieć prawidłową nazwę!");
        }

        [Test]
        public void IsValidLogFileName_ValidFileUpperCased_ReturnsTrue()
        {
            bool result = m_Analyzer.IsValidLogFileName("whatever.SLF");

            Assert.IsTrue(result);
        }

        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("plikozlymrozszerzeniu.foo");

            Assert.False(result);
        }

        [Test]
        public void IsValidLogFileName_EmptyFileName_Throws()
        {
            LogAnalyzer logAnalyzer = MakeAnalyzer();

            var exc = Assert.Throws<ArgumentException>(() => logAnalyzer.IsValidLogFileName(""));

            StringAssert.Contains("należy podać nazwę pliku", exc.Message);
        
        }

        //[Test]
        //[Ignore("z tym testem jest problem")]
        //public void IsValidLogFileName_ValidFile_ReturnsTrue()
        //{
        //    //--
        //}

        [Test]
        [Category("szybkie testy")]
        public void IsValidLogFileName_ValidFile_ReturnsTrue()
        {

        }

  

        [TearDown]
        public void TearDown()
        {
            m_Analyzer = null;
        }

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }


        
      
    }
}
