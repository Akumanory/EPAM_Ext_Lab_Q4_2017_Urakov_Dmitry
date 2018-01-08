namespace Task03
{
    using System;

    class Program
    {
        /*
         Напишите заготовку для векторного графического редактора. 
         Полная версия редактора должна позволять создавать и выводить на экран такие фигуры как: Линия, Окружность, Прямоугольник, Круг, Кольцо. 
         Заготовка, для упрощения, должна представлять собой консольное приложение с функционалом:
         */
        static void Main(string[] args)
        {
            string figure;
            Console.WriteLine("This is a list of figures: \nCircle\nLine\nRectangle\nRing\nRound\nEnter name of a figure that you want to choose.\nFor example 'round', 'ring', etc.");
            figure = Console.ReadLine();

            switch (figure)
            {
                case"circle":
                    Circle circle = new Circle();
                    FigureInformationToConsole(circle);
                    break;

                case"line":
                    Line line = new Line();
                    FigureInformationToConsole(line);
                    break;

                case"rectangle":
                    Rectangle rectangle = new Rectangle();
                    FigureInformationToConsole(rectangle);
                    break;

                case"ring":
                    Ring ring = new Ring();
                    FigureInformationToConsole(ring);
                    break;

                case"round":
                    Round round = new Round();
                    FigureInformationToConsole(round);
                    break;

                default:
                    Console.WriteLine("Incorrect name of figure");
                    break;
            }

            Console.ReadKey();
        }

        public static void FigureInformationToConsole(Figure obj)
        {
            Console.WriteLine("Enter the value of coordinate 'x'");
            obj.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of coordinate 'y'");
            obj.Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Figure type is {0} with coordinates x = {1} and y = {2}", obj.FigureType, obj.X, obj.Y);
        }
    }
}
