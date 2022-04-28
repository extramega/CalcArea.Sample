using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcArea;

namespace UnitTestArea
{
    /// <summary>Проверка методов класса <see cref="Figure"/> без знания типа фигуры в compile-time</summary>
    [TestClass]
    public class UnitTestFigure
    {
        /// <summary>Проверка входного параметра - объекта <see cref="IFigure"/></summary>
        [TestMethod]
        public void TestMethodException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Figure.Area((IFigure?)null));
        }

        /// <summary>Проверка вычисления площади фигуры</summary>
        [TestMethod]
        public void TestMethodArea()
        {
            double r = 1;
            double expected = Math.PI * Math.Pow(r, 2);
            var circle = new Circle(r);
            double actual = Figure.Area(circle);
            Assert.AreEqual(expected, actual, 0, "Ошибка вычисления площади круга");

            expected = 6;
            var triangle = new Triangle(3, 4, 5);
            actual = Figure.Area(triangle);
            Assert.AreEqual(expected, actual, 0, "Ошибка вычисления площади треугольника");
        }
    }
}