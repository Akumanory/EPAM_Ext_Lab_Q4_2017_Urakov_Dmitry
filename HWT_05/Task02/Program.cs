namespace Task02
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        { 
            int a = 0,
                b = 0,
                c = 0;

            Console.WriteLine("Enter the value of line 'a':");
            int.TryParse(Console.ReadLine(), out a);
            
            Console.WriteLine("Enter the value of line 'b':");
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Enter the value of line 'c':");
            int.TryParse(Console.ReadLine(), out c);

            Triangle triangle = new Triangle(a, b, c);

            Console.WriteLine("Triangle with lines a = {0}, b = {1}, c = {2} have:\nPerimeter of triangle = {3} \nArea of triangle = {4}", triangle.A, triangle.B, triangle.C, triangle.Perimeter(), triangle.Area());

            Console.ReadKey();
        }
    }
}
