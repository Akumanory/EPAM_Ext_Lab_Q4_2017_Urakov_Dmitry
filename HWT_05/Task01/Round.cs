namespace Task01
{
    using System;

    public class Round
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
            get { return this.r; }
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
        public double GetLenght()
        {
            return 2 * this.r * Math.PI;
        }

        /// <summary>
        /// Возвращает площадь окружности
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return this.r * this.r * Math.PI;
        }
    }
}
