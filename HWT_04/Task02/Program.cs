namespace Task02
{
    using System;
    using System.Text;

    public class Program
    {
        /*
         Написать программу, которая удваивает в первой введенной строки все символы, принадлежащие второй введенной строке.
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first sentence");
            StringBuilder firstSent = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Enter second sentence");
            StringBuilder secondSent = new StringBuilder(Console.ReadLine());

            DoubleWord(firstSent, secondSent);
        
            Console.ReadKey();
        }

        /// <summary>
        /// Дублирует буквы в первом предложении, которые встречаются во втором.
        /// </summary>
        /// <param name="firstSent">Первое предложение</param>
        /// <param name="secondSent">Второе предложение</param>
        public static void DoubleWord(StringBuilder firstSent, StringBuilder secondSent)
        {
            StringBuilder thirdSent = new StringBuilder();

            char[] charArrFirst = firstSent.ToString().Trim().ToCharArray();

            char[] charArrSecond = secondSent.ToString().Trim().ToCharArray();

            for (int i = 0; i < charArrFirst.Length; i++)
            {
                bool coincidence = false;

                for (int j = 0; j < charArrSecond.Length; j++)
                {
                    if (charArrFirst[i] == charArrSecond[j] & charArrFirst[i] != ' ')
                    {
                        coincidence = true;
                        thirdSent.Append(charArrFirst[i]).Append(charArrFirst[i]);
                    }
                }

                if (coincidence == false)
                {
                    thirdSent.Append(charArrFirst[i]);
                }
            }

            Console.WriteLine("Result sentence: {0}", thirdSent);
        }
    }
}
