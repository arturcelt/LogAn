using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using static LogAn.LogAnalyzer;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void overrideTestWithoutStub()
        {
            TestableLogAnalyzer logan = new TestableLogAnalyzer();
            logan.IsSupported = true;

            bool result = logan.IsValidLogFileName("test.ext");

            Assert.True(result, "...");
        }

        

      
    }

    
    class TestableLogAnalyzer: LogAnalyzer
    {
        public bool IsSupported;

        protected override bool IsValid(string fileName)
        {
            return IsSupported;
        }

    }




}
