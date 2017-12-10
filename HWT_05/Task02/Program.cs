namespace Task02
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int tmp = 0; 
            Triangle triangle = new Triangle();

            do
            {
                Console.WriteLine("Enter the value of line 'a':");
                triangle.A = AssignmentOfValues(tmp);

                Console.WriteLine("Enter the value of line 'b':");
                triangle.B = AssignmentOfValues(tmp);

                Console.WriteLine("Enter the value of line 'c':");
                triangle.C = AssignmentOfValues(tmp);

                if (triangle.IsTriangleExist() == false)
                {
                    Console.WriteLine("Triangle with this lines can not be exist. \nEnter the values of lines againe.");
                }
                else
                {
                    Console.WriteLine("Triangle with this lines exist.");
                }
            } 
            while (triangle.IsTriangleExist() != true);

            Console.WriteLine("Perimeter of triangle = {0} \nArea of triangle = {1}", triangle.Perimeter(), triangle.Area());

            Console.ReadKey();
        }

        /// <summary>
        /// Проверка ввода с клавиатуры
        /// </summary>
        /// <param name="tmp">Параметр для передачи значения</param>
        /// <returns></returns>
        public static int AssignmentOfValues(int tmp)
        {
            int.TryParse(Console.ReadLine(), out tmp);
            return tmp;
        }
    }
}
