namespace Task03
{
    using System;

    class Rectangle : Figure
    {
        FiguresShapes type = FiguresShapes.Rectangle;

        public Rectangle()
        {
            FigureType = type.ToString();
        }
    }
}
