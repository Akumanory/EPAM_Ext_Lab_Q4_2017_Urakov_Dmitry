using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task02
{
    class Program
    {

        /*
         Дано действительное число h. Выяснить, имеет ли уравнение ax2 + bx + c = 0 действительные корни.
         */
        static void Main(string[] args)
        {
            double h,a,b,c,discriminant,x1,x2;

            Console.WriteLine("Ведите действительное число h");
            double.TryParse(Console.ReadLine(), out h);

            a = Math.Sqrt(((Math.Abs(Math.Sin(8 * h))) + 17) / (1 - Math.Sin(4 * h) * Math.Cos(h * h + 18) * (1 - Math.Sin(4 * h) * Math.Cos(h * h + 18))));
            Console.WriteLine("Значение а = " + a );

            b = 1 - Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(a * h * h) - Math.Sin(a * h))));
            Console.WriteLine("Значение b = " + b );

            c = a * h * h * Math.Sin(b * h) + (b * h * h * h) * Math.Cos(a * h);
            Console.WriteLine("Значение c = " + c);

            discriminant = b * b - 4 * a * c;
            Console.WriteLine("Значение дискриминанта = " + discriminant);

            if (discriminant >= 0)
            {
                Console.WriteLine("Уравнение имеет действительные корни, т.к. дискриминант = " + discriminant + ">=0");
                x1 = (-b + discriminant) / (2 * a);
                x2 = (-b - discriminant) / (2 * a);
                Console.WriteLine("Первый корень {0}.\nВторой корень {1}.", x1, x2);
            }
            else
            {
                Console.WriteLine("Действительных корней нет.");
            }





            Console.ReadLine();


        }
    }
}
