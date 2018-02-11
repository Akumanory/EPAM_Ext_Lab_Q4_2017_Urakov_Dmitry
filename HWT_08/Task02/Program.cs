using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Office office = new Office();

            Person john = new Person("John");
            Person hugo = new Person("Hugo");

            ConsoleKeyInfo button;

            //В консоле пока не указал какие кнопки что делают
            do
            {
                button = Console.ReadKey();

                switch (button.Key)
                {
                    case ConsoleKey.F1:
                        {
                            office.timeEvent.TimeBefore12();
                        }
                        break;

                    case ConsoleKey.F2:
                        {
                            office.timeEvent.TimeBetween12and17();
                        }
                        break;
                    case ConsoleKey.F3:
                        {
                            office.timeEvent.TimeUnder17();
                        }
                        break;

                    case ConsoleKey.F4:
                        {
                            office.employeeEvent.EmployeeCame(john);
                        }
                        break;

                    case ConsoleKey.F5:
                        {
                            office.employeeEvent.EmployeeOut(john);
                        }
                        break;

                    case ConsoleKey.F6:
                        {
                            office.employeeEvent.EmployeeCame(hugo);
                        }
                        break;

                    case ConsoleKey.F7:
                        {
                            office.employeeEvent.EmployeeOut(hugo);
                        }
                        break;
                }


            } while (button.Key != ConsoleKey.Escape);

            Console.ReadKey();

        }
    }
}
