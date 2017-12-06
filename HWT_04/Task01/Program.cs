namespace Task01
{
    using System;
    using System.Text;

    public class Program
    {
        /*
         Написать программу, которая определяет среднюю длину слова во введенной текстовой строке. 
         Учесть, что символы пунктуации на длину слов влиять не должны. 
         Регулярные выражения не использовать. И не пытайтесь прописать все ручками. 
         Используйте стандартные методы класса String.
         */
        public static void Main(string[] args)
        {
            string question = string.Empty; 

            do
            {
                char[] charArr;
                do
                {
                    Console.WriteLine("Enter the line");

                    StringBuilder line = new StringBuilder(Console.ReadLine());

                    charArr = line.ToString().Trim().ToCharArray(0, line.ToString().Trim().Length);

                    AverageWordLength(charArr, line);
                } 
                while (charArr.GetLength(0) == 0);

                Console.WriteLine("\nIf you want to end, type 'No'\nIf you want to use program againg type anything");
                question = Console.ReadLine();
            } 
            while (question != "No");

            Console.ReadKey();
        }

        /// <summary>
        /// Выводит на экран значение средней длины слова в предложении.
        /// </summary>
        /// <param name="charArr">Массив состоящий из символов введенного предложения</param>
        /// <param name="line">Введенное предложение</param>
        public static void AverageWordLength(char[] charArr, StringBuilder line)
        {
            int numberOfLines = 1;
            int numberOfCharacter = 0;

            if (charArr.GetLength(0) != 0)
            {
                for (int i = 1; i < line.Length + 1; i++)
                {
                    if (charArr[i - 1] == ' ' && charArr[i] != ' ')
                    {
                        numberOfLines++;
                    }

                    if (charArr[i - 1] != ',' & charArr[i - 1] != '.' & charArr[i - 1] != ' ')
                    {
                        numberOfCharacter++;
                    }
                }

                Console.WriteLine("Number of lines: {0}, Number of characters: {1}", numberOfLines, numberOfCharacter);
                Console.WriteLine("Average word length: {0}", (int)(numberOfCharacter / numberOfLines));
            }
            else
            {
                Console.WriteLine("An empty line was entered");
            }
        }
    }
}
