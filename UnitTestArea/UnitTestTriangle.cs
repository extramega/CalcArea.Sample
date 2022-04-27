using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestArea
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TestMethodException()
        {
            Assert.ThrowsException<ArgumentException>(() => new CalcArea.Triangle(-1, 1, 2));
            Assert.ThrowsException<ArgumentException>(() => new CalcArea.Triangle(1, 2, 5));
        }

        [TestMethod]
        public void TestMethodArea()
        {
            double expected = 6;
            double actual = new CalcArea.Triangle(3, 4, 5).Area();
            Assert.AreEqual(expected, actual, 0, "Ошибка вычисления площади треугольника");
        }
    }
}