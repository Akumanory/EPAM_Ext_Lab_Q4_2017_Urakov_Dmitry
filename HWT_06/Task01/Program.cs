namespace Task01
{
    using System;

   public class Program
    {
        /*
         На основе класса User (см. задание 3 из предыдущей темы), создать класс Employee, описывающий сотрудника фирмы. 
         В дополнение к полям пользователя добавить поля «стаж работы» и «должность». 
         Обеспечить нахождение класса в заведомо корректном состоянии.
         */
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            FillingFieldsAndOutputToConsole(employee);

            Console.ReadKey();
        }

        /// <summary>
        /// Выводит введенные значения для полей класса
        /// </summary>
        /// <param name="employee">Экзэмпляр класса</param>
        public static void FillingFieldsAndOutputToConsole(Employee employee)
        {
            int year, day, month;
            DateTime startWorkExpirience, endWorkExpirience;

            Console.WriteLine("Enter Name of user:");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Enter Surname of user:");
            employee.Surname = Console.ReadLine();

            Console.WriteLine("Enter Patronymic of user:");
            employee.Patronymic = Console.ReadLine();

            Console.WriteLine("Enter Year of user's born:");
            int.TryParse(Console.ReadLine(), out year);

            Console.WriteLine("Enter Month of user's born:");
            int.TryParse(Console.ReadLine(), out month);

            Console.WriteLine("Enter Day of user's born:");
            int.TryParse(Console.ReadLine(), out day);

            employee.DateOfBorn = new DateTime(year, month, day);
            employee.GetAgeByBirthDate();

            Console.WriteLine("Enter the position of employee");
            employee.Position = Console.ReadLine();

            Console.WriteLine("Enter the start date of work experience:");
            startWorkExpirience = WorkExpirienceAssigment(employee, year, month, day);

            Console.WriteLine("Enter the end date of work experience:");
            endWorkExpirience = WorkExpirienceAssigment(employee, year, month, day);

            Console.WriteLine("\nName:\t\t{0}\nSurname:\t{1}\nPatronymic:\t{2}\nDateOfBorn:\t{3:yyyy MM dd}\nAge:\t\t{4}\nWork expirience {5} years from:\t{6:yyyy MM dd} to {7:yyyy MM dd}\nPosition\t{8}", employee.Name, employee.Surname, employee.Patronymic, employee.DateOfBorn, employee.Age, endWorkExpirience.Year - startWorkExpirience.Year, startWorkExpirience, endWorkExpirience, employee.Position);
        }

        public static DateTime WorkExpirienceAssigment(Employee employee, int year, int month, int day)
        {
            Console.WriteLine("Enter Year of user's work expirience:");
            int.TryParse(Console.ReadLine(), out year);

            Console.WriteLine("Enter Month of user's work expirience:");
            int.TryParse(Console.ReadLine(), out month);

            Console.WriteLine("Enter Day of user's work expirience:");
            int.TryParse(Console.ReadLine(), out day);

            return employee.WorkExperience = new DateTime(year, month, day);
        }
    }
}
