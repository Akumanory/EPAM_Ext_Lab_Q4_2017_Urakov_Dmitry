namespace Task02
{
    using System;

    public class Program
    {
        /*
         Создать класс Ring (кольцо), описываемое координатами центра, внешним и внутренним радиусами, 
         а также свойствами, позволяющими узнать площадь кольца и суммарную длину внешней и внутренней границ кольца. 
         Обеспечить нахождение класса в заведомо корректном состоянии.
         */
        public static void Main(string[] args)
        {
            Ring ring = new Ring();

            FillingFieldsAndOutputToConsole(ring);

            Console.ReadKey();
        }

        /// <summary>
        /// Выводит введенные значения для полей класса
        /// </summary>
        /// <param name="ring">Экзэмпляр класса</param>
        public static void FillingFieldsAndOutputToConsole(Ring ring)
        {
            int tmp = 0;
           
            Console.WriteLine("Enter the value of coordinate 'x':");
            ring.X = AssignmentOfValues(tmp);

            Console.WriteLine("Enter the value of coordinate 'y':");
            ring.Y = AssignmentOfValues(tmp);

            Console.WriteLine("Enter the value of 'inner radius':");
            ring.InnerRadius = AssignmentOfValues(tmp);

            Console.WriteLine("Enter the value of 'outter radius':");
            ring.OutterRadius = AssignmentOfValues(tmp);

            while (ring.OutterRadius < ring.InnerRadius)
            {
                Console.WriteLine("Incorrect outter radius 'outter radius must be larger than inner radius', enter 'outter radius' again:");
                ring.OutterRadius = AssignmentOfValues(tmp);
            }

            Console.WriteLine("\nSum of inner and outter boder in ring: {0}\nValue of ring area: {1}", ring.SumLenghtOfRing(ring.OutterRadius, ring.InnerRadius), ring.SumAreaOfRing(ring.OutterRadius, ring.InnerRadius));
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
