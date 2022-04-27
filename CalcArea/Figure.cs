namespace CalcArea
{
    public class Figure : IFigure
    {
        public IFigure Shape { get; private set; }
        public Figure(object figure)
        {
            if (figure is Circle c)
                Shape = c;
            else if (figure is Triangle t)
                Shape = t;
            else
                throw new ArgumentException("Фигура не определена");
        }

        public double Area()
        {
            return Shape.Area();
        }
    }
}