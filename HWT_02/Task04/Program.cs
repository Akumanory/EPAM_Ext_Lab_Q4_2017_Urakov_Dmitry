namespace Task04
{
    using System;

    public class Program
    {
        /*
         Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее «изображение», состоящее из N треугольников
         */
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter lines number");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 1; i <= n; i++)
            {
                int count = 1;

                for (int j = 1; j <= i; j++)
                {
                    string a = new string(' ', n - j);
                    string b = new string('*', count);
                    count += 2;
                    a += b;
                    Console.WriteLine(a);
                }
            }

            Console.ReadLine();
        }
    }
}
