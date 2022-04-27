namespace CalcArea
{
    public class Triangle : IFigure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
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

        public double Area()
        {
            var p = (A + B + C) / 2;
            var s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return s;
        }

        public bool IsRectangular()
        {
            double[] ar = new double[] { A, B, C }.OrderBy(x => x).ToArray();
            return Math.Pow(ar[2], 2) == Math.Pow(ar[0], 2) + Math.Pow(ar[1], 2);
        }
    }
}