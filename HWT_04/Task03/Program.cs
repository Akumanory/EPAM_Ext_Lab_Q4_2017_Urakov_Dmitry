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
            OperationsWorkTime(10000);
            OperationsWorkTime(100000);
            OperationsWorkTime(200000);
            OperationsWorkTime(300000);
            OperationsWorkTime(400000);
            OperationsWorkTime(500000);
            OperationsWorkTime(600000);
            
            Console.ReadKey();
        }

        /// <summary>
        /// Выводит в крнсоль данный о времени действия операций
        /// </summary>
        /// <param name="n">Количество итераций цикла</param>
        public static void OperationsWorkTime(int n)
        {
            string str = string.Empty;
            StringBuilder sb = new StringBuilder();
            Stopwatch stopwatchFirst = new Stopwatch();
            Stopwatch stopwatchSecond = new Stopwatch();

            long time = 0;

            Console.WriteLine("Test for {0} iterations", n);

            for (int i = 0; i < n; i++)
            {
                stopwatchFirst.Start();
                str += "*";
                stopwatchFirst.Stop();
                time += stopwatchFirst.ElapsedMilliseconds;
            }

            Console.WriteLine("Average value of millisecond for string: {0}", (long)time / n);

            time = 0;
            for (int i = 0; i < n; i++)
            {
                stopwatchSecond.Start();
                sb.Append("*");
                stopwatchSecond.Stop();
                time += stopwatchSecond.ElapsedMilliseconds;
            }

            Console.WriteLine("Average value of millisecond for StringBuilder: {0}\n", (long)time / n); 
        }
    }
}
