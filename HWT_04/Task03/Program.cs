namespace Task03
{
    using System;
    using System.Diagnostics;
    using System.Text;

    public class Program
    {
        /*
         Проведите сравнительный анализ скорости работы классов String и StringBuilder для операции сложения строк.
         */
        public static void Main(string[] args)
        {
            int numberOfIterations;
            Console.WriteLine("Enter number of iterations for operation sum of strings");
            int.TryParse(Console.ReadLine(), out numberOfIterations);
            Console.WriteLine();

            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("{0} Analysis", i);
                OperationsWorkTime(numberOfIterations);//todo pn хардкод 
            }
			
			
            
            Console.ReadKey();
        }

        /// <summary>
        /// Выводит в крнсоль данный о времени действия операций
        /// </summary>
        /// <param name="n">Количество итераций цикла</param>
        public static void OperationsWorkTime(int n)
        {
            string stringLine = string.Empty;
            string stringForSum = "*";
            StringBuilder stringBuilderLine = new StringBuilder();
            Stopwatch stopwatchFirst = new Stopwatch();
            Stopwatch stopwatchSecond = new Stopwatch();

            long time = 0;

            Console.WriteLine("Test for {0} iterations", n);

            for (int i = 0; i < n; i++)
            {
                stopwatchFirst.Start();
                stringLine += stringForSum;//todo pn хардкод
                stopwatchFirst.Stop();
                time += stopwatchFirst.ElapsedMilliseconds;
            }

            Console.WriteLine("Average value of millisecond for String class: \t\t{0}", (long)time / n);

            time = 0;
            for (int i = 0; i < n; i++)
            {
                stopwatchSecond.Start();
                stringBuilderLine.Append(stringForSum);
                stopwatchSecond.Stop();
                time += stopwatchSecond.ElapsedMilliseconds;
            }

            Console.WriteLine("Average value of millisecond for StringBuilder class: \t{0}\n", (long)time / n); 
        }
    }
}
