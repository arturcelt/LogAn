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
        public void ctor_WhenViewIsLoaded_CallsViewRender()
        {
            var mockView = Substitute.For<IView>();

            Presenter p = new Presenter(mockView);
            mockView.Loaded += Raise.Event<Action>();

            mockView.Received().Render(Arg.Is<string>(s => s.Contains("Witaj świecie")));
        }
    }
}
