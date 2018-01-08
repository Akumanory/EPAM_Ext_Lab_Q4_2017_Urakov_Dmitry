namespace Task03
{
    using System;

    class Circle : Figure
    {
        FiguresShapes type = FiguresShapes.Circle;
        public Circle()
        {
            FigureType = type.ToString();
        }
    }
}
