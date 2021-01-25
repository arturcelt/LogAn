using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class ExampleTests
    {
        [Test]
        public void Returns_ByDefault_WorksForHardCodedArgument()
        {
            IFileNameRules fakeRules = Substitute.For<IFileNameRules>();

            fakeRules.IsValidLogFileName("strict.txt").Returns(true);

            Assert.True(fakeRules.IsValidLogFileName("strict.txt"));

        }
    }
}
