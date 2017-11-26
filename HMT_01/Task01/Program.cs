using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        /*
         Написать консольное приложение, которое проверяет принадлежность точки заштрихованной области.
         Пользователь вводит координаты точки (x; y) и выбирает букву графика (a-к). 
         * В консоли должно высветиться сообщение: «Точка [(x; y)] принадлежит фигуре [г]».
         */
        static void Main(string[] args)
        {
            double x, y;
            bool a = false;
            string graphLetter;

          
            Console.WriteLine("Веведите значение координаты x");
            double.TryParse(Console.ReadLine(), out x);
         
            
            Console.WriteLine("Веведите значение координаты y");
            double.TryParse(Console.ReadLine(), out y);

            do
            {
                Console.WriteLine("Введите букву графика (от а до к)");
                graphLetter = Console.ReadLine();
                #region
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
                    Console.WriteLine("Неверное значение");
                        break;
                }
                #endregion
            } while (a == false);

            Calculation(x, y, graphLetter);

            Console.ReadKey();
        }

        /// <summary>
        /// GraphA вычисляет принадлежность точки к каждому графику графику.
        /// </summary>
        /// <param name="x">Значение координаты х.</param>
        /// <param name="y">Значение координаты y.</param>
        /// <param name="graphLetter">Название графика.</param>
        public static void Calculation(double x, double y, string graphLetter)
        {

            switch (graphLetter)
            {
                case "а":
            
                    if (x*x + y*y <= 1)
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику "+ graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;

                case "б":

                    if ((x * x + y * y <= 1) & (x * x + y * y >= 0.5))
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику " + graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;

                case "в":

                    if ((x <= 1) & (x >= -1) & (y <= 1) & (y >= -1))
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику " + graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;

                case "г":

                    if ((x * y / 2 >= -0.5) | (x * y / 2 <= 0.5))
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику " + graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;

                case "д":

                    if ((x <= 0.5) & (x >= -0.5) & (y <= 1) & (y >= -1) & ((x * y / 2 >= -0.25) | (x * y / 2 <= 0.25)))
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику " + graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;

                case "е":

                    if (((x>=-2)&(x<=0)&(y<=1)&(y>=-1)&((x*y/2 <= 1)|(x*y/2 >= -1)))|((x>=0)&(x<=1)&(y<=1)&(y>=-1)&(x * x + y * y <= 1)))
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику " + graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;

                case "ж":

                    if ( (((-1.5 - x) * (2 + 1) - (0 + 1.5) * (-1 - y))>0 ) & (((0 - x) * (-1 - 2) - (1.5 - 0) * (2 - y))>0 ) & (((1.5 - x) * (-1 + 1) - (-1.5 - 1.5) * (-1 - y))>0) |
                         (((-1.5 - x) * (2 + 1) - (0 + 1.5) * (-1 - y)) < 0) & (((0 - x) * (-1 - 2) - (1.5 - 0) * (2 - y)) < 0) & (((1.5 - x) * (-1 + 1) - (-1.5 - 1.5) * (-1 - y)) < 0) |
                         (((-1.5 - x) * (2 + 1) - (0 + 1.5) * (-1 - y)) == 0) | (((0 - x) * (-1 - 2) - (1.5 - 0) * (2 - y)) < 0) & (((1.5 - x) * (-1 + 1) - (-1.5 - 1.5) * (-1 - y)) == 0))
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику " + graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;

                case "з":

                    if ( ((x>=0)&(x<=1)&(y-x<=0)&(y>=-2)) |
                         ((x<=0)&(x>=-1)&(-x-y>=0)&(y>=-2))
                        )
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику " + graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;

                case "и":

                    if (((x-3*y<=1)&(y<0)&(x>=0))|((x<=0)&(x-3*y<=1)&(2*x-y>=-3)&(y+x<=0)))
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику " + graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;

                case "к":

                    if (((x<=-1)&(y>=1))|((x<=0)&(x>=-1)&(y+x>=0))|((x>=0)&(x<=1)&(x-y<=0))|((x>=1)&(y>=1)))
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " принадлежит графику " + graphLetter);
                    }
                    else
                    {
                        Console.WriteLine("Координата с точкой x=" + x + " и точкой y=" + y + " не принадлежит графику " + graphLetter);
                    }
                    break;
            }



        }
    }
}
