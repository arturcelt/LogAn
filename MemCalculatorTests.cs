using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class MemCalculatorTests
    {
        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            MemCalculator calc = new MemCalculator();

            int lastSum = calc.Sum();

            Assert.AreEqual(0, lastSum);
        }
    }
}
