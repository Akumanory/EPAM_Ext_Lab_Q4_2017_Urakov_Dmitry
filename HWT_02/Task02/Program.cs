namespace Task02
{
    using System;

    public class Program
    {
        /*
         Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее «изображение», состоящее из N строк.
         */
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter lines number");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 1; i < n + 1; i++)
            {
                string a = new string('*', i);
                Console.WriteLine("{0}", a); ////todo pn в заднии не просили вставлять пробел
            }

            Console.ReadLine();
        }
    }
}
