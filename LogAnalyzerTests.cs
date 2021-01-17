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
        public void overriderTest()
        {
            FakeExtensionManager stub = new FakeExtensionManager();
            stub.WillBeValid = true;
            TestableLogAnalyzer logan = new TestableLogAnalyzer(stub);

            bool result = logan.IsValidLogFileName("file.ext");

            Assert.True(result);
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

    class TestableLogAnalyzer: LogAnalyzer
    {
        public IExtensionManager Manager;

        public TestableLogAnalyzer(IExtensionManager extensionManager)
        {
            Manager = extensionManager;
        }

        protected override IExtensionManager GetManager()
        {
            return Manager;
        }

    }




}
