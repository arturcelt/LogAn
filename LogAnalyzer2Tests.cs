using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzer2Tests
    {
    

        [Test]
        public void Analyze_LoggerThrows_CallsWebService()
        {
            FakeWebService mockWebServcie = new FakeWebService();

            FakeLogger2 stubLogger = new FakeLogger2();
            stubLogger.WillThrow = new Exception("sztuczny wyjątek");

            var analyzer2 = new LogAnalyzer2(stubLogger, mockWebServcie);

            analyzer2.MinNameLenght = 8;

            string toShortFileName = "abc.ext";
            analyzer2.Analyze(toShortFileName);

            StringAssert.Contains("Błąd z rejestratora: sztuczny wyjątek", mockWebServcie.MessageToWebService);


        }
    }
}


