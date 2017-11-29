namespace Task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PointBelonging
    {
        /// <summary>
        /// GraphA вычисляет принадлежность точки к каждому графику графику.
        /// </summary>
        /// <param name="x">Значение координаты х.</param>
        /// <param name="y">Значение координаты y.</param>
        /// <param name="graphLetter">Название графика.</param>
        public static void Calculation(double x, double y, string graphLetter)
        {
            bool a = false;
            switch (graphLetter)
            {
                case "а":
            
                    if (a = (x * x) + (y * y) <= 1)
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;

                case "б":

                    if (a = ((x * x) + (y * y) <= 1) & ((x * x) + (y * y) >= 0.5))
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;

                case "в":

                    if (a = (x <= 1) & (x >= -1) & (y <= 1) & (y >= -1))
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;

                case "г":

                    if (a = (x * y / 2 >= -0.5) | (x * y / 2 <= 0.5))
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;

                case "д":

                    if (a = (x <= 0.5) & (x >= -0.5) & (y <= 1) & (y >= -1) & ((x * y / 2 >= -0.25) | (x * y / 2 <= 0.25)))
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;

                case "е":

                    if (a = ((x >= -2) & (x <= 0) & (y <= 1) & (y >= -1) & (((x * y) / 2 <= 1) | ((x * y) / 2 >= -1))) | ((x >= 0) & (x <= 1) & (y <= 1) & (y >= -1) & ((x * x) + (y * y) <= 1)))
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;

                case "ж":

                    if (a = ((((-1.5 - x) * (2 + 1)) - ((0 + 1.5) * (-1 - y))) > 0) & ((((0 - x) * (-1 - 2)) - ((1.5 - 0) * (2 - y))) > 0) & ((((1.5 - x) * (-1 + 1)) - ((-1.5 - 1.5) * (-1 - y))) > 0) |
                         ((((-1.5 - x) * (2 + 1)) - ((0 + 1.5) * (-1 - y))) < 0) & ((((0 - x) * (-1 - 2)) - ((1.5 - 0) * (2 - y))) < 0) & ((((1.5 - x) * (-1 + 1)) - ((-1.5 - 1.5) * (-1 - y))) < 0) |
                         ((((-1.5 - x) * (2 + 1)) - ((0 + 1.5) * (-1 - y))) == 0) | ((((0 - x) * (-1 - 2)) - ((1.5 - 0) * (2 - y))) < 0) & ((((1.5 - x) * (-1 + 1)) - ((-1.5 - 1.5) * (-1 - y))) == 0))
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;

                case "з":

                    if (a = ((x >= 0) & (x <= 1) & (y - x <= 0) & (y >= -2)) | ((x <= 0) & (x >= -1) & (-x - y >= 0) & (y >= -2)))
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;

                case "и":

                    if (a = ((x - (3 * y) <= 1) & (y < 0) & (x >= 0)) | ((x <= 0) & (x - (3 * y) <= 1) & ((2 * x) - y >= -3) & (y + x <= 0)))
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;

                case "к":

                    if (a = ((x <= -1) & (y >= 1)) | ((x <= 0) & (x >= -1) & (y + x >= 0)) | ((x >= 0) & (x <= 1) & (x - y <= 0)) | ((x >= 1) & (y >= 1)))
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }
                    else
                    {
                        CoordinateBelonging(x, y, graphLetter, a);
                    }

                    break;
            }
        }

        /// <summary>
        /// Метотод выводит строку говорящую о том что координата либо принадлежит, либо не принадлежит графику.
        /// </summary>
        /// <param name="x">Точка х координаты.</param>
        /// <param name="y">Точка у координаты.</param>
        /// <param name="graphLetter">Буква графика.</param>
        /// <param name="belonging">Проверка вхождения координаты в график.</param>
        private static void CoordinateBelonging(double x, double y, string graphLetter, bool belonging) ////todo pn методы можно объединить в один
        {
            if (belonging)
            {
                Console.WriteLine("Coordinate with dot x= {0} and dot y= {1} belongs to graph '{2}'", x, y, graphLetter);
            }
            else 
            {
                Console.WriteLine("Coordinate with dot x= {0} and dot y= {1} do not belongs to graph '{2}'", x, y, graphLetter);
            } 
        }
    }
}
