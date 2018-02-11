namespace Task01
{
    using System;
    using System.Collections.Generic;
    
    public delegate bool Function(string string1, string string2);  

    public class Program
    {
        /*
        Написать программу, выполняющую сортировку массива строк по возрастанию длины. 
        Если строки состоят из равного числа символов, их следует отсортировать по алфавиту. 
        Реализовать метод сравнения строк отдельным методом, передаваемым в сортировку через делегат.
        */

        public static void Main(string[] args)
        {
            List<string> stringArray = new List<string>();

            TestStringValues(stringArray);

            Function funcSwapCondition = new Function(SwapCondition);

            AscendingArrayStringSort(stringArray, funcSwapCondition);

            Console.ReadKey();
        }

        public static void AscendingArrayStringSort(List<string> stringArray, Function func)
        {
            Console.WriteLine("Unsorted strings\n");

            foreach (var a in stringArray)
            {
                Console.WriteLine(a);
            }

            for (int i = 1; i < stringArray.Count; i++)
            {
                int j = i;
                string temp = stringArray[i];
 
                while (j > 0 && func(stringArray[j - 1], temp))
                {
                    stringArray[j] = stringArray[j - 1];
                    j--;
                }

                stringArray[j] = temp;
            }

            Console.WriteLine("\nSorted strings\n");

            foreach (var a in stringArray)
            {
                Console.WriteLine(a);
            }
        }

        public static bool SwapCondition(string string1, string string2)
        {
            if (string1.Length == string2.Length)
            {                
                for (int i = 0; i < string1.Length; i++)
                {
                    if (string1.ToCharArray()[i] < string2.ToCharArray()[i])
                    {
                        return false;
                    }

                    if (string1.ToCharArray()[i] > string2.ToCharArray()[i])
                    {
                        return true;
                    }     
                }
            }

            if (string1.Length > string2.Length)
            {
                return true;
            }

            if (string1.Length < string2.Length)
            {
                return false;
            }

            return false;
        }

        public static void TestStringValues(List<string> stringArray)
        {
            stringArray.Add("aasgs");
            stringArray.Add("bassf");
            stringArray.Add("bdndfgaaaaa");
            stringArray.Add("ccdss");
            stringArray.Add("adraafgaaaa");
            stringArray.Add("bbsln");
            stringArray.Add("absgh");
            stringArray.Add("bckss");
            stringArray.Add("s");
            stringArray.Add("cc");
            stringArray.Add("aa");
            stringArray.Add("k");
            stringArray.Add("mna");
            stringArray.Add("nma");
        }
    }
}
