using System;
using System.Collections.Generic;
using System.Text;
using NSubstitute;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class SomeViewTests
    {
        [Test]
        public void EventFiringManual()
        {
            bool loadFired = false;
            SomeView view = new SomeView();
            view.Load += delegate { loadFired = true; };

            view.DoSomethingThatEventuallyFiresThisEvent();

            Assert.IsTrue(loadFired);
        }
    }
}
