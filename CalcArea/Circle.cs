using System;

namespace CalcArea
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }
        public static readonly double RadiusMaxValue = Math.Sqrt(double.MaxValue) / Math.PI;
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус слишком маленький");
            if (radius > RadiusMaxValue)
                throw new ArgumentException("Радиус слишком большой");
            Radius = radius;
        }

        public virtual double Area()
        {
            var s = Math.PI * Math.Pow(Radius, 2);
            return s;
        }
    }
}