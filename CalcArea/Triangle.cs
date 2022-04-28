namespace CalcArea
{
    /// <summary>Класс для вычисления площади треугольника по трем сторонам</summary>
    public class Triangle : IFigure
    {
        /// <summary>Сторона треугольника</summary>
        public double A { get; private set; }
        /// <summary>Сторона треугольника</summary>
        public double B { get; private set; }
        /// <summary>Сторона треугольника</summary>
        public double C { get; private set; }
        /// <summary>Конструктор для создания сущности с проверкой на корректность входных параметров</summary>
        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Стороны треугольника должны быть больше нуля");
            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("Из указанных сторон нельзя получить треугольник");
            A = a;
            B = b;
            C = c;
        }

        /// <summary>Вычисление площади треугольника</summary>
        public double Area()
        {
            var p = (A + B + C) / 2;
            var s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return s;
        }

        /// <summary>Проверка на то, является ли треугольник прямоугольным</summary>
        public bool IsRectangular()
        {
            double[] ar = new double[] { A, B, C }.OrderBy(x => x).ToArray();
            return Math.Pow(ar[2], 2) == Math.Pow(ar[0], 2) + Math.Pow(ar[1], 2);
        }
    }
}