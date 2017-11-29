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
            switch (graphLetter)
            {
                case "а":
            
                    if ((x * x) + (y * y) <= 1)
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;

                case "б":

                    if (((x * x) + (y * y) <= 1) & ((x * x) + (y * y) >= 0.5))
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;

                case "в":

                    if ((x <= 1) & (x >= -1) & (y <= 1) & (y >= -1))
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;

                case "г":

                    if ((x * y / 2 >= -0.5) | (x * y / 2 <= 0.5))
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;

                case "д":

                    if ((x <= 0.5) & (x >= -0.5) & (y <= 1) & (y >= -1) & ((x * y / 2 >= -0.25) | (x * y / 2 <= 0.25)))
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;

                case "е":

                    if (((x >= -2) & (x <= 0) & (y <= 1) & (y >= -1) & (((x * y) / 2 <= 1) | ((x * y) / 2 >= -1))) | ((x >= 0) & (x <= 1) & (y <= 1) & (y >= -1) & ((x * x) + (y * y) <= 1)))
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;

                case "ж":

                    if (((((-1.5 - x) * (2 + 1)) - ((0 + 1.5) * (-1 - y))) > 0) & ((((0 - x) * (-1 - 2)) - ((1.5 - 0) * (2 - y))) > 0) & ((((1.5 - x) * (-1 + 1)) - ((-1.5 - 1.5) * (-1 - y))) > 0) |
                         ((((-1.5 - x) * (2 + 1)) - ((0 + 1.5) * (-1 - y))) < 0) & ((((0 - x) * (-1 - 2)) - ((1.5 - 0) * (2 - y))) < 0) & ((((1.5 - x) * (-1 + 1)) - ((-1.5 - 1.5) * (-1 - y))) < 0) |
                         ((((-1.5 - x) * (2 + 1)) - ((0 + 1.5) * (-1 - y))) == 0) | ((((0 - x) * (-1 - 2)) - ((1.5 - 0) * (2 - y))) < 0) & ((((1.5 - x) * (-1 + 1)) - ((-1.5 - 1.5) * (-1 - y))) == 0))
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;

                case "з":

                    if (((x >= 0) & (x <= 1) & (y - x <= 0) & (y >= -2)) | ((x <= 0) & (x >= -1) & (-x - y >= 0) & (y >= -2)))
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;

                case "и":

                    if (((x - (3 * y) <= 1) & (y < 0) & (x >= 0)) | ((x <= 0) & (x - (3 * y) <= 1) & ((2 * x) - y >= -3) & (y + x <= 0)))
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;

                case "к":

                    if (((x <= -1) & (y >= 1)) | ((x <= 0) & (x >= -1) & (y + x >= 0)) | ((x >= 0) & (x <= 1) & (x - y <= 0)) | ((x >= 1) & (y >= 1)))
                    {
                        CoordinateBelongs(x, y, graphLetter);
                    }
                    else
                    {
                        CoordinateDoNotBelongs(x, y, graphLetter);
                    }

                    break;
            }
        }

        /// <summary>
        /// Метотод выводит строку говорящую о том что координата принадлежит графику.
        /// </summary>
        /// <param name="x">Точка х координаты.</param>
        /// <param name="y">Точка у координаты.</param>
        /// <param name="graphLetter">Буква графика.</param>
        private static void CoordinateBelongs(double x, double y, string graphLetter)
        {
            Console.WriteLine("Coordinate with dot x= {0} and dot y= {1} belongs to graph '{2}'", x, y, graphLetter);
        }

        /// <summary>
        /// Метотод выводит строку говорящую о том что координата не принадлежит графику.
        /// </summary>
        /// <param name="x">Точка х координаты.</param>
        /// <param name="y">Точка у координаты</param>
        /// <param name="graphLetter">Буква графика.</param>
        private static void CoordinateDoNotBelongs(double x, double y, string graphLetter)
        {
            Console.WriteLine("Coordinate with dot x= {0} and dot y= {1} do not belongs to graph '{2}'", x, y, graphLetter);
        }
    }
}
