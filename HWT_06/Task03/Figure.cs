namespace Task03
{
    using System;

    class Figure
    {
        private int x;
        private int y;
        private string figureType;//todo pn для этого используют enum

        public int X
        {
            get { return x; }

            set { x = value; }
        }

        public int Y
        {
            get { return y; }

            set { y = value; }
        }

        public string FigureType
        {
            get { return figureType; }

            set { figureType = value; }
        } 
       
    }
}
