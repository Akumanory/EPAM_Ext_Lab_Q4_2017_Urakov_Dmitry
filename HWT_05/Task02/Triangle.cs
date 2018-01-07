namespace Task02
{
    using System;

    public class Triangle
    {
        private int a;
        private int b;
        private int c;
        private bool state;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if ((a < b + c) & (b < a + c) & (c < a + b))
            {
                state = true;
            }
            else
            {
                state = false;
                Console.WriteLine("Triangle with this lines can not be exist"); 
            }
        }

        public int A
        {
            get
            {
                return this.a;
            }
        }

        public int B
        {
            get 
            { 
                return this.b; 
            }
        }

        public int C
        {
            get
            {
                return this.c; 
            }
        }
       
        public int Perimeter()
        {
            int perimetr;

            if (state != false)
            {
                perimetr = this.a + this.b + this.c;
            }
            else
            {
                perimetr = 0;
                Console.WriteLine("Perimentr do not exists");
            }

            return perimetr;   
        }

        public double Area()
        {
            double area;  

            if (state != false)
            {
                double p = this.Perimeter() / 2;
                area = Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
            }
            else
            {
                area = 0;
                Console.WriteLine("Area do not exists");
            }

            return area;
        }
    }
}
