namespace Task02
{
    using System;

    public class Triangle
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get
            {
                return this.a;
            }

            set
            {
                if (value > 0)
                {
                    this.a = value;
                }
            }
        }

        public int B
        {
            get 
            { 
                return this.b; 
            }

            set
            {
                if (value > 0)
                {
                    this.b = value;
                }
            }
        }

        public int C
        {
            get
            {
                return this.c; 
            }

            set
            {
                if (value > 0)
                {
                    this.c = value;
                }
            }
        }

        public bool IsTriangleExist()
        {
            if ((this.a < this.b + this.c) & (this.b < this.a + this.c) & (this.c < this.a + this.b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Perimeter()
        {
            return this.a + this.b + this.c;
        }

        public double Area()
        {
            double p = this.Perimeter() / 2;
            return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
        }
    }
}
