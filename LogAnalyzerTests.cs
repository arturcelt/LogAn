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
        public void Analyze_TooShortFileName_CallsWebService()
        {
            FakeWebService mockService = new FakeWebService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string toShortFileName = "abc.ext";

            log.Analyze(toShortFileName);

            StringAssert.Contains("Nazwa pliku jest zbyt krótka:abc.ext", mockService.LastError);
            
        }




    }

    
    



}
