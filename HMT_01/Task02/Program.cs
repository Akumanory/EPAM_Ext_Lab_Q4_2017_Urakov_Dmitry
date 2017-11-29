namespace Task02
{
    using System;

    public class Program
    {
        /*
         Дано действительное число h. Выяснить, имеет ли уравнение ax2 + bx + c = 0 действительные корни.
         */
<<<<<<< HEAD
        public static void Main(string[] args) ////todo pn частное решение для общей задачи (вычисление корней квадратного уравнения)
=======
        public static void Main(string[] args)//todo pn частное решение для общей задачи (вычисление корней квадратного уравнения)
>>>>>>> 91e77b73e44ab96d772b904c4a97af577e0847b0
        {
            double h, a, b, c, discriminant;

            Console.WriteLine("Enter a real number h");
            double.TryParse(Console.ReadLine(), out h);

            a = Math.Sqrt((Math.Abs(Math.Sin(8 * h)) + 17) / ((1 - (Math.Sin(4 * h) * Math.Cos((h * h) + 18))) * (1 - (Math.Sin(4 * h) * Math.Cos((h * h) + 18)))));
            Console.WriteLine("Value а = {0}", a);

            b = 1 - Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(a * h * h) - Math.Sin(a * h))));
            Console.WriteLine("Value b = {0}", b);

            c = (a * h * h * Math.Sin(b * h)) + ((b * h * h * h) * Math.Cos(a * h));
            Console.WriteLine("Value c = {0}", c);

            discriminant = (b * b) - (4 * a * c);
            Console.WriteLine("Value of discriminant = {0}", discriminant);

            RootFind(a, b, discriminant);

            Console.ReadLine();
        }

        /// <summary>
        /// Находит корни уравнения
        /// </summary>
        /// <param name="a">Значение переменной а</param>
        /// <param name="b">Значение переменной в</param>
        /// <param name="discriminant">Значение дискриминанта</param>
            public static void RootFind(double a, double b, double discriminant)
            {
                double x1, x2;
                if (discriminant >= 0)
                {
                    Console.WriteLine("Equation has real roots, because discriminant = {0}>=0", discriminant);
                    x1 = (-b + discriminant) / (2 * a);
                    x2 = (-b - discriminant) / (2 * a);
                    Console.WriteLine("First root {0}.\nSecond root {1}.", x1, x2);
                }
                else
                {
                    Console.WriteLine("No real roots.");
                }
            }
    }
}
