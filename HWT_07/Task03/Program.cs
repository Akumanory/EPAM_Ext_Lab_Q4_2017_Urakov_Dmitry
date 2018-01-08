namespace Task03
{
    using System;

    public class Program
    {
        /*
         На базе обычного массива (коллекции .NET не использовать) реализовать свой собственный класс DynamicArray, представляющий собой массив с запасом.
         */
        public static void Main(string[] args)
        {
            int[] ar = new int[] { 6, 3, 7 };

            DynamicArray<int> array = new DynamicArray<int>(3);

            array.Add(3);
            array.Add(2);
            array.Add(7);
            array.Add(9);

            array.AddRange(ar);

            array.Insert(4, 28);

            foreach (var a in array)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n{0}", array.Lenght);

            Console.ReadKey();
        }     
    }
}
