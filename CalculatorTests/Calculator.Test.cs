using NUnit.Framework;
using System;
using System.IO.IsolatedStorage;
using UnitTesTask;
using Xunit.Sdk;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTest

    {


        [Test]
        public void AdditionalExpectReturnSummOfTowNumbers()
        {
            var calc = new Calculator();
            Assert.AreEqual(calc.Additional(5, 10), 15);
        }
        [Test]
        public void SubtractionTwoNumbers()
        {
            var calc = new Calculator();
            Assert.AreEqual(calc.Subtraction(10, 5), 5);
        }
        [Test]
        public void MultiplicationTwoNumbers()
        {
            var calc = new Calculator();
            Assert.AreNotEqual(calc.Miltiplication(10, 5), 5);
        }
        [Test]
        public void DevisionTwoNumbers()
        {
            var calc = new Calculator();
            Assert.That(calc.Division(10, 5), Is.EqualTo(2));
            Assert.Throws<DivideByZeroException>(() => calc.Division(10, 0));

        }
    }
}