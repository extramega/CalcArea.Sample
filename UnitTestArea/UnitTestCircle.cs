using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestArea
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void TestMethodException()
        {
            Assert.ThrowsException<ArgumentException>(() => new CalcArea.Circle(-1));
            Assert.ThrowsException<ArgumentException>(() => new CalcArea.Circle(double.MaxValue));
        }

        [TestMethod]
        public void TestMethodArea()
        {
            double r = 1;
            double expected = Math.PI * Math.Pow(r, 2);
            var circle = new CalcArea.Circle(r);
            double actual = circle.Area();
            Assert.AreEqual(expected, actual, 0, "Ошибка вычисления площади круга");
        }
    }
}