using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcArea;

namespace UnitTestArea
{
    /// <summary>Проверка методов класса <see cref="Triangle"/></summary>
    [TestClass]
    public class UnitTestTriangle
    {
        /// <summary>Проверка создания объекта <see cref="Triangle"/></summary>
        [TestMethod]
        public void TestMethodException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 1, 2));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 5));
        }

        /// <summary>Проверка вычисления площади треугольника</summary>
        [TestMethod]
        public void TestMethodArea()
        {
            double expected = 6;
            double actual = new Triangle(3, 4, 5).Area();
            Assert.AreEqual(expected, actual, 0, "Ошибка вычисления площади треугольника");
        }
    }
}