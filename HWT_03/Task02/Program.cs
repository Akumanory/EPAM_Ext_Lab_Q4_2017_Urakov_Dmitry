namespace Task02
{
    using System;

    public class Program
    {
        /*
         Написать программу, которая заменяет все положительные элементы в трёхмерном массиве на нули. 
         Число элементов в массиве и их тип определяются разработчиком.
         */
        public static void Main(string[] args)
        {
            int numberOfElementsByX = 0, numberOfElementsByY = 0, numberOfElementsByZ = 0;

            Console.WriteLine("Enter number of elements in array by x");
            int.TryParse(Console.ReadLine(), out numberOfElementsByX);
            Console.WriteLine("Enter number of elements in array by y");
            int.TryParse(Console.ReadLine(), out numberOfElementsByY);
            Console.WriteLine("Enter number of elements in array by z");
            int.TryParse(Console.ReadLine(), out numberOfElementsByZ);

            int[,,] arr = new int[numberOfElementsByX, numberOfElementsByY, numberOfElementsByZ];

            FillArray(arr, numberOfElementsByX, numberOfElementsByY, numberOfElementsByZ);
            ArrayToConsole(arr, numberOfElementsByX, numberOfElementsByY, numberOfElementsByZ);
            AllPositiveToZeroInArray(arr, numberOfElementsByX, numberOfElementsByY, numberOfElementsByZ);
            ArrayToConsole(arr, numberOfElementsByX, numberOfElementsByY, numberOfElementsByZ);

            Console.ReadKey();
        }

        /// <summary>
        /// Заполняет массив значениями
        /// </summary>
        /// <param name="arr">Передаваеммый массив</param>
        /// <param name="numByX">Количество элемнтов по х</param>
        /// <param name="numByY">Количество элемнтов по y</param>
        /// <param name="numByZ">Количество элемнтов по z</param>
        /// <returns>Возвращает заполненный массив</returns>
        public static int[,,] FillArray(int[,,] arr, int numByX, int numByY, int numByZ)
        {
            Console.WriteLine("Array filled by random values:");
            Random rand = new Random();
            for (int i = 0; i < numByX; i++)
            {
                for (int j = 0; j < numByY; j++)
                {
                    for (int k = 0; k < numByZ; k++)
                    {
						arr[i, j, k] = rand.Next(100) - 50;//todo pn хардкод
                    }
                }  
            }

            return arr;
        }

        /// <summary>
        /// Выводит значения массива в консоль
        /// </summary>
        /// <param name="arr">Передаваеммый массив</param>
        /// <param name="numByX">Количество элемнтов по х</param>
        /// <param name="numByY">Количество элемнтов по y</param>
        /// <param name="numByZ">Количество элемнтов по z</param>
        public static void ArrayToConsole(int[,,] arr, int numByX, int numByY, int numByZ)
        {
            for (int k = 0; k < numByZ; k++)
            {
                Console.WriteLine("\nPlane z = {0}", k + 1);
                for (int i = 0; i < numByX; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < numByY; j++)
                    {
                        Console.Write(arr[i, j, k] + "\t"); 
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Заменяет все положительный элементы массива заменяются на ноль
        /// </summary>
        /// <param name="arr">Передаваеммый массив</param>
        /// <param name="numByX">Количество элемнтов по х</param>
        /// <param name="numByY">Количество элемнтов по y</param>
        /// <param name="numByZ">Количество элемнтов по z</param>
        public static void AllPositiveToZeroInArray(int[,,] arr, int numByX, int numByY, int numByZ)
        {
            for (int k = 0; k < numByZ; k++)
            {
                for (int i = 0; i < numByX; i++)
                { 
                    for (int j = 0; j < numByY; j++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0; 
                        }
                    }
                }
            }

            Console.WriteLine("All positive values to zero:");
        }
    }
}
