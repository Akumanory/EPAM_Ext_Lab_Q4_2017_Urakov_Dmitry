namespace Task02
{
    using System;

    public class Circle
    {
        private int x;
        private int y;
        private int r;

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public int Radius
        {
            get
            {
                return this.r; 
            }

            set
            {
                if (value > 0)
                {
                    this.r = value;
                }
            }
        }

        /// <summary>
        /// Возвращает длину окружности
        /// </summary>
        /// <returns></returns>
        public double GetLenght(int r)
        {
            return 2 * r * Math.PI;
        }

        /// <summary>
        /// Возвращает площадь окружности
        /// </summary>
        /// <returns></returns>
        public double GetArea(int r)
        {
            return r * r * Math.PI;
        }
    }
}
