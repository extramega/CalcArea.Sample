namespace CalcArea
{
    /// <summary>Класс для вычисления площади фигуры без знания типа фигуры в compile-time</summary>
    public static class Figure
    {
        /// <summary>Вычисление площади фигуры</summary>
        /// <typeparam name="T">Тип фигуры</typeparam>
        /// <param name="figure">Объект фигуры</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static double Area<T>(T figure) where T : IFigure?
        {
            if (figure == null)
                throw new ArgumentNullException(nameof(figure));
            return figure.Area();
        }
    }
}