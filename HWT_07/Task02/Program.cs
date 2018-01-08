namespace Task02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        /*
         Задан английский текст. 
         Выделить отдельные слова и для каждого посчитать частоту встречаемости. 
         Слова, отличающиеся регистром, считать одинаковыми. 
         В качестве разделителей считать пробел и точку.
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the text");
           
            string enteredString = Console.ReadLine();

            CountDublicatesInString(enteredString);

            Console.ReadKey();
        }

        /// <summary>
        /// Считает для каждого слова сколько раз оно встречается в тексте. 
        /// </summary>
        /// <param name="enteredString">Переменная текста</param>
        public static void CountDublicatesInString(string enteredString)
        {

            List<string> list = new List<string>();

            String[] words = enteredString.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                list.Add(words[i]);
            }


            List<string> listWithoutDublicates = new List<string>(list.Distinct());

            for (int i = 0; i < listWithoutDublicates.Count; i++)
            {
                int countWords = 0;

                for (int j = 0; j < list.Count; j++)
                {
                    if (listWithoutDublicates[i].Equals(list[j]))
                    {
                        countWords++;
                    }
                }

                if (countWords != 0)
                {
                    Console.WriteLine("Word {0} \toccurs {1} times", listWithoutDublicates[i], countWords);
                }
            }
        } 

    }
}
