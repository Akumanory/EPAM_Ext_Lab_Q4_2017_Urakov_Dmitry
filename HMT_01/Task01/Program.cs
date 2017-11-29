namespace Task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        /*
         Написать консольное приложение, которое проверяет принадлежность точки заштрихованной области.
         Пользователь вводит координаты точки (x; y) и выбирает букву графика (a-к). 
         * В консоли должно высветиться сообщение: «Точка [(x; y)] принадлежит фигуре [г]».
         */
        public static void Main(string[] args)
        {
            double x, y;
            bool a = false;
            string graphLetter;

            Console.WriteLine("Enter the value of the coordinate x");
            double.TryParse(Console.ReadLine(), out x);

            Console.WriteLine("Enter the value of the coordinate y");
            double.TryParse(Console.ReadLine(), out y);

            do
            {
                Console.WriteLine("Enter the letter of the graph (from 'а' to 'к')");
                graphLetter = Console.ReadLine();
             
                switch (graphLetter)
                {
                    case "а":
                        a = true;
                        break;
                    case "б":
                        a = true;
                        break;
                    case "в":
                        a = true;
                        break;
                    case "г":
                        a = true;
                        break;
                    case "д":
                        a = true;
                        break;
                    case "е":
                        a = true;
                        break;
                    case "ж":
                        a = true;
                        break;
                    case "з":
                        a = true;
                        break;
                    case "и":
                        a = true;
                        break;
                    case "к":
                        a = true;
                        break;

                    default:
                        Console.WriteLine("Incorrect value");
                        break;
                }
            } 
            while (a == false);

            PointBelonging.Calculation(x, y, graphLetter);

            Console.ReadKey();
        }
    }
}
