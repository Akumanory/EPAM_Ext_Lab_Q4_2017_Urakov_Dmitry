namespace Task02
{
    using System;

    public class Ring  
    {
        private int outterRadius;
        private int innnerRadius;
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

        public int InnerRadius
        {
            get
            {
                return innnerRadius;
            }

            set
            {
                innnerRadius = value;   
            }
        }

        public int OutterRadius
        {
            get
            {
                return outterRadius;
            }

            set
            {
                if (innnerRadius < value)
                {
                    outterRadius = value;
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

        public double SumLenghtOfRing(int outterRadius, int innerRadius)
        {
            return GetLenght(outterRadius) + GetLenght(innerRadius);
        }

        public double SumAreaOfRing(int outterRadius, int innerRadius)
        {
            return GetArea(outterRadius) - GetArea(innerRadius);
        }
    }
}
