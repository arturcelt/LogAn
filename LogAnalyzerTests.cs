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
        public void IsValidLogFileName_SupportedExteions_ReturnsTrue()
        {
            LogAnalyzer log = new LogAnalyzer();
            log.ExtensionManager = someFakeManagerCreatedErlier;
           //-- ASERCJA LOGIKI PRZY ZAŁOŻENIU ŻE ROŻSZERZENIE JEST OBSŁUGIWANE

        }

        

      
    }

    internal class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;

        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }

}
