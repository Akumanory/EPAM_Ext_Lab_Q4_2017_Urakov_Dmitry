namespace Task01
{
    using System;
    using System.Collections;

    public class Program
    {
        /*
         В кругу стоят N человек, пронумерованных от 1 до N. 
         При ведении счета по кругу вычёркивается каждый второй человек, пока не останется один. 
         Составить программу, моделирующую процесс.
         */
        public static void Main(string[] args)
        {
            int numberInCircle = 0;

            Console.WriteLine("Please enter a number of people in circle");

            int.TryParse(Console.ReadLine(), out numberInCircle);

            ModelProcessOfTask(numberInCircle);

            Console.ReadKey();
        }

        /// <summary>
        /// Моделирует процесс задачи
        /// </summary>
        /// <param name="numberOfElements">Количество находящихся в кругу</param>
        public static void ModelProcessOfTask(int numberOfElements)
        {
            int circleCounting = 0;
            ArrayList array = new ArrayList();
            for (int i = 1; i <= numberOfElements; i++)
            {
                array.Add(i);
            }

            Console.WriteLine("Number of people in a circle = {0}", array.Count);

            ArrayOutput(array, circleCounting);

            while (array.Count > 1)
            {
               circleCounting++;
                for (int i = 0; i < array.Count; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        array.RemoveAt(i);
                    }
                }

                ArrayOutput(array, circleCounting);   
            }
        }

        /// <summary>
        /// Опеспечивает вывод итераций задачи на консоль
        /// </summary>
        /// <param name="array">Массив значений</param>
        /// <param name="circleCounting">Подсчет итераций задачи</param>
        public static void ArrayOutput(ArrayList array, int circleCounting)
        {
            Console.WriteLine("({0}) iteration circle counting:", circleCounting);
            foreach (var num in array)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();
        }
    }
}
