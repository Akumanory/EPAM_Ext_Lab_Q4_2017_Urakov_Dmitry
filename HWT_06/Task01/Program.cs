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
            int year, day, month, workExperience;

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

            Console.WriteLine("Enter the number of years of work experience:");
            if (int.TryParse(Console.ReadLine(), out workExperience) == true)
            {
                employee.WorkExperience = workExperience;
            }

            Console.WriteLine("Enter the position of employee");
            employee.Position = Console.ReadLine();

            Console.WriteLine("\nName:\t\t{0}\nSurname:\t{1}\nPatronymic:\t{2}\nDateOfBorn:\t{3:yyyy MM dd}\nAge:\t\t{4}\nWork expirience\t{5}\nPosition\t{6}", employee.Name, employee.Surname, employee.Patronymic, employee.DateOfBorn, employee.Age, employee.WorkExperience, employee.Position);
        }
    }
}
