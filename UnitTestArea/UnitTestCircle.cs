using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcArea;

namespace UnitTestArea
{
    /// <summary>Проверка методов класса <see cref="Circle"/></summary>
    [TestClass]
    public class UnitTestCircle
    {
        /// <summary>Проверка создания объекта <see cref="Circle"/></summary>
        [TestMethod]
        public void TestMethodException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
            Assert.ThrowsException<ArgumentException>(() => new Circle(double.MaxValue));
        }

        /// <summary>Проверка вычисления площади круга</summary>
        [TestMethod]
        public void TestMethodArea()
        {
            double r = 1;
            double expected = Math.PI * Math.Pow(r, 2);
            var circle = new Circle(r);
            double actual = circle.Area();
            Assert.AreEqual(expected, actual, 0, "Ошибка вычисления площади круга");
        }
    }
}