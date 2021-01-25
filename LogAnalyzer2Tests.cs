using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzer2Tests
    {
        [Test]
        public void Analyze_LoggerThrows_CallsWebService()
        {
            var mockWebService = Substitute.For<IWebService>();
            var stubLogger = Substitute.For<ILogger>();
            stubLogger.When(logger => logger.LogError(Arg.Any<string>())).Do(info => { throw new Exception("sztuczny wyjątek"); });

            var analyzer = new LogAnalyzer2(stubLogger, mockWebService);
            analyzer.MinNameLenght = 10;
            analyzer.Analyze("short.txt");

            mockWebService.Received().Write(Arg.Is<string>(s => s.Contains("sztuczny wyjątek")));
        }
    }
}


