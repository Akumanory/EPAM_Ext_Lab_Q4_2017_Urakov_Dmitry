namespace Task03
{
    using System;

    public class Program
    {
        /*
         Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее «изображение», состоящее из N строк.
         */
        public static void Main(string[] args)
        {
            int count = 1, n;

            Console.WriteLine("Enter lines number");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = n; i > 0; i--)
            {
                string a = new string(' ', i);
                string b = new string('*', count);
                a += b;
                count += 2;
                Console.WriteLine("{0}", a);
            }

            Console.ReadKey();
        }
    }
}
