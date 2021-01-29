using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class PresenterTests
    {
        
        [Test]
        public void ctor_WhenViewHasError_CallsLogger()
        {
            var stubView = Substitute.For<IView>();
            var mockLogger = Substitute.For<ILogger>();

            Presenter p = new Presenter(stubView, mockLogger);
            stubView.ErrorOccured += Raise.Event<Action<string>>("sztuczny błąd");

            mockLogger.Received().LogError(Arg.Is<string>(s => s.Contains("sztuczny błąd")));
        }

       
    }
}
