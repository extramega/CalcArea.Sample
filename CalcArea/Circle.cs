namespace CalcArea
{
    /// <summary>Класс для вычисления площади круга по радиусу</summary>
    public class Circle : IFigure
    {
        /// <summary>Радиус круга</summary>
        public double Radius { get; private set; }
        /// <summary>Максимальное значение для радиуса круга</summary>
        public static readonly double RadiusMaxValue = Math.Sqrt(double.MaxValue) / Math.PI;
        /// <summary>Конструктор для создания объекта с проверкой на корректность входных параметров</summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус слишком маленький");
            if (radius > RadiusMaxValue)
                throw new ArgumentException("Радиус слишком большой");
            Radius = radius;
        }

        /// <summary>Вычисление площади круга</summary>
        public double Area()
        {
            var s = Math.PI * Math.Pow(Radius, 2);
            return s;
        }
    }
}