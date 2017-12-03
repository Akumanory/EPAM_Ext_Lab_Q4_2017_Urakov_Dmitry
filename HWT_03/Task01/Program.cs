namespace Task01
{
    using System;

    public class Program
    {
        /*
         Написать программу, которая генерирует случайным образом элементы массива (число элементов в массиве и их тип определяются разработчиком), 
         определяет для него максимальное и минимальное значения, сортирует массив и выводит полученный результат на экран.
         Примечание: LINQ запросы и готовые функции языка (Sort, Max и т.д.) использовать в данном задании запрещается.
         */
        public static void Main(string[] args)
        {
            int numberOfElements = 0;

            Console.WriteLine("Enter number of elements in array");

            int.TryParse(Console.ReadLine(), out numberOfElements);

            int[] arr = new int[numberOfElements];  

            FillArray(arr);
            MaxAndMinValuesOfArray(arr);
            AscendingArraySort(arr);

            Console.ReadKey();
        }

        /// <summary>
        /// Заполняет массив случайными числами.
        /// </summary>
        /// <param name="arr">Передаваемый массив</param>
        /// <returns>Возвращает заполненный массив</returns>
        public static int[] FillArray(int[] arr)
        {
            Console.WriteLine("Array filled by random values:");
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
                Console.WriteLine("Array element[{0}] = {1}", i, arr[i]);
            }
           
            return arr;
        }

        /// <summary>
        /// Определяет максимальное и минимальное значение в массиве.
        /// </summary>
        /// <param name="arr">Передаваемый массив</param>
        public static void MaxAndMinValuesOfArray(int[] arr)
        {
            int maxValue = int.MinValue, minValue = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }

                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }

            Console.WriteLine("Max value of array = {0} \nMin value of array = {1}", maxValue, minValue);
        }

        /// <summary>
        /// Сортирует значения массива по врзрастанию.
        /// </summary>
        /// <param name="arr">Передаваемый массив.</param>
        public static void AscendingArraySort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i;

                while (j > 0 && arr[j - 1] > current)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = current;   
            }

            Console.WriteLine("Array sorted in ascending order:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array element[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
