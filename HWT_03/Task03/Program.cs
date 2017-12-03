namespace Task03
{
    using System;

    public class Program
    {
        /*
         Написать программу, которая определяет сумму неотрицательных элементов в одномерном массиве. 
         Число элементов в массиве и их тип определяются разработчиком.
         */
        public static void Main(string[] args)
        {
            int numberOfElements = 0;

            Console.WriteLine("Enter number of elements in array");

            int.TryParse(Console.ReadLine(), out numberOfElements);

            int[] arr = new int[numberOfElements];

            FillArray(arr);
            SumOfPositiveValues(arr);

            Console.ReadKey();
        }

        /// <summary>
        /// Заполняет массив случайными числами
        /// </summary>
        /// <param name="arr">Передаваемый массив</param>
        /// <returns>Возвращает заполненный массив</returns>
        public static int[] FillArray(int[] arr)
        {
            Console.WriteLine("Array filled by random values:");
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100) - 50;
                Console.WriteLine("Array element[{0}] = {1}", i, arr[i]);
            }

            return arr;
        }

        /// <summary>
        /// Сумма позитивных значений
        /// </summary>
        /// <param name="arr">Передаваемый массив</param>
        public static void SumOfPositiveValues(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                } 
            }

            Console.WriteLine("Sum of positive values in array = {0}", sum);
        }
    }
}
