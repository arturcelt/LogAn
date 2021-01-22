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
        public void Analyze_WebServiceThrows_SendsEmail()
        {
            FakeWebService stubService = new FakeWebService();
            stubService.ToThrow = new Exception("Sztuczny wyjątek");
            FakeEmailService mockEmail = new FakeEmailService();

            LogAnalyzer2 log = new LogAnalyzer2(stubService, mockEmail);
            string toShortFileName = "abc.ext";
            log.Analyze(toShortFileName);

            StringAssert.Contains("someone@somewhere.com", mockEmail.To);
            StringAssert.Contains("Sztuczny wyjątek", mockEmail.Body);
            StringAssert.Contains("Brak możliwości rejestracji", mockEmail.Subject);

        }
    }
}
