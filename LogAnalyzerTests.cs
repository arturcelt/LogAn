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
            ExtensionManagerFactory.SetManager(myFakeManager);
            LogAnalyzer log = new LogAnalyzer();

            //-- ASERCJA PRZY ZAŁOŻENIU ŻE ROZSZERZENIE JEST OBSŁUGIWANE
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
