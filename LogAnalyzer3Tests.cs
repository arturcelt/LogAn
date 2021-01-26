using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;


namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzer3Tests
    {
        [Test]
        public void Analyze_LoggerThrows_CallWebServiceWithNSubjectObject()
        {
            var mockWebService = Substitute.For<IWebService>();
            var stubLogger = Substitute.For<ILogger>();
            stubLogger.When(logger => logger.LogError(Arg.Any<string>())).Do(info => { throw new Exception("sztuczny wyjątek"); });
            var analyzer = new LogAnalyzer3(stubLogger, mockWebService);
            analyzer.MinNameLenght = 10;

            analyzer.Analyze("Short.txt");

            mockWebService.Received().Write(Arg.Is<ErrorInfo>(info => info.Severity == 1000 && info.Message.Contains("sztuczny wyjątek")));

        }

        [Test]
        public void Analyze_LoggerThrows_CallWebServiceWithNSubjectObjectCompare()
        {
            var mockWebService = Substitute.For<IWebService>();
            var stubLogger = Substitute.For<ILogger>();
            stubLogger.When(logger => logger.LogError(Arg.Any<string>())).Do(info => { throw new Exception("sztuczny wyjątek"); });
            LogAnalyzer3 analyzer = new LogAnalyzer3(stubLogger, mockWebService);
            analyzer.MinNameLenght = 10;

            analyzer.Analyze("Short.txt");

            var exptected = new ErrorInfo(1000, "sztuczny wyjątek");
            mockWebService.Received().Write(exptected);

        }
    }
}
