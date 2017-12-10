namespace Task01
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int tmp = 0;
            Round round = new Round();

            Console.WriteLine("Enter the value of coordinate 'x':");
            round.X = AssignmentOfValues(tmp); 

            Console.WriteLine("Enter the value of coordinate 'y':");
            round.Y = AssignmentOfValues(tmp); 

            Console.WriteLine("Enter the value of 'radius':");
            round.Radius = AssignmentOfValues(tmp); 

            while (round.Radius == 0)
            {
                Console.WriteLine("Incorrect value of 'radius', enter value againe");
                round.Radius = AssignmentOfValues(tmp); 
            }

            Console.WriteLine("Entered values: \n'x' = {0}\n'y' = {1}\n'radius' = {2}", round.X, round.Y, round.Radius);

            Console.WriteLine("The length of the circle: {0}\nThe area of the circle: {1}", round.GetLenght(), round.GetArea());

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
