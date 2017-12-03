namespace Task01
{
    using System;
    /*
     Написать программу, которая определяет площадь прямоугольника со сторонами a и b.
     Если пользователь вводит некорректные значения (отрицательные, или 0), должно выдаваться сообщение об ошибке.
     Возможность ввода пользователем строки вида «абвгд», или нецелых чисел игнорировать.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            double a, b;

            do
            {
                Console.WriteLine("\nEnter the value of line 'a'");
                double.TryParse(Console.ReadLine(), out a);
                ErrorMessage(a);
                Console.WriteLine("\nEnter the value of line 'b'");
                double.TryParse(Console.ReadLine(), out b);
                ErrorMessage(b);
            }
            while ((a <= 0) | (b <= 0));

            AreaOfRectangle(a, b);

            Console.ReadLine();
        }

        /// <summary>
        /// Определяет и сообщает об ошибке если есть.
        /// </summary>
        /// <param name="t">Проверяемая переменная.</param>
        public static void ErrorMessage(double t) ////todo pn неинформативное название метода
        {
            if (t <= 0)
            {
                Console.WriteLine("Incorrect value");
            }
        }

        /// <summary>
        /// Определяет площадь прямоугольника.
        /// </summary>
        /// <param name="a">Сторона прямоугольника а.</param>
        /// <param name="b">Сторона прямоугольника в.</param>
        public static void AreaOfRectangle(double a, double b)
        {
            Console.WriteLine("\nArea of rectangle is S= {0}", a * b);
        }
    }
}