namespace Task05
{
    using System;

    public class Program
    {
        /*
         Если выписать все натуральные числа меньше 10, кратные 3, или 5, то получим 3, 5, 6 и 9.  
         Сумма этих чисел будет равна 23. 
         Напишите программу, которая выводит на экран сумму всех чисел меньше 1000, кратных 3, или 5.
         */
        public static void Main(string[] args)//todo pn частное решение
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }

            Console.WriteLine("Sum of natural numbers which are less then 1000 is \n'Sum' = {0} ",  sum);

            Console.ReadKey();
        }
    }
}
