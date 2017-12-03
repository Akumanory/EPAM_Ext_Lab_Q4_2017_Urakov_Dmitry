namespace Task04
{
    using System;

    public class Program
    {
        /*
         Элемент двумерного массива считается стоящим на чётной позиции, 
         если сумма номеров его позиций по обеим размерностям является чётным числом (например, [1,1] – чётная позиция, а [1,2] - нет). 
         Определить сумму элементов массива, стоящих на чётных позициях.
         */
        public static void Main(string[] args)
        {
            int numberOfElementsByX = 0, numberOfElementsByY = 0; 
            Console.WriteLine("Enter number of elements in array by x");
            int.TryParse(Console.ReadLine(), out numberOfElementsByX);
            Console.WriteLine("Enter number of elements in array by y");
            int.TryParse(Console.ReadLine(), out numberOfElementsByY);

            int[,] arr = new int[numberOfElementsByX, numberOfElementsByY];

            FillArray(arr, numberOfElementsByX, numberOfElementsByY);
            SumOfValuesOnEvenPosition(arr, numberOfElementsByX, numberOfElementsByY);

            Console.ReadKey();
        }

        /// <summary>
        /// Заполнение массива с помощью случайных значений
        /// </summary>
        /// <param name="arr">Передаваеммый массив</param>
        /// <param name="numX">Количество элемнтов по х</param>
        /// <param name="numY">Количество элемнтов по y</param>
        /// <returns>Возвращает заполненный массив</returns>
        public static int[,] FillArray(int[,] arr, int numX, int numY)
        {
            Console.WriteLine("Array filled by random values:");
            Random rand = new Random();
            for (int i = 0; i < numX; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < numY; j++)
                {
                    arr[i, j] = rand.Next(100) - 30;
                    Console.Write(arr[i, j] + "\t"); 
                }
            }

            Console.WriteLine();

            return arr;
        }

        /// <summary>
        /// Сумму элементов массива, стоящих на чётных позициях
        /// </summary>
        /// <param name="arr">Передаваеммый массив</param>
        /// <param name="numX">Количество элемнтов по х</param>
        /// <param name="numY">Количество элемнтов по y</param>
        public static void SumOfValuesOnEvenPosition(int[,] arr, int numX, int numY)
        {
            int sum = 0;

            for (int i = 0; i < numX; i++)
            {
                for (int j = 0; j < numY; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            Console.WriteLine("\nSum of values on even positions  = {0}", sum);
        } 
    }
}
