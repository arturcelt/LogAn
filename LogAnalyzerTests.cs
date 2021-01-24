using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;

namespace LogAn.UnitTests
{
    [TestFixture]
    class LogAnalyzerTests
    {
        [Test]
        public void Analyze_ToShortFileName_CallLogger()
        {
            FakeLogger logger = new FakeLogger();

            LogAnalyzer analyzer = new LogAnalyzer(logger);

            analyzer.MinNameLength = 6;
            analyzer.Analyze("a.txt");

            StringAssert.Contains("za krótka", logger.LastError);
        }
    }
}
