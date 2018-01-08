namespace Task03
{
    using System;

    class Line : Figure
    {
        FiguresShapes type = FiguresShapes.Line;

        public Line()
        {
            FigureType = type.ToString();
        }
    }
}
