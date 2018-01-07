namespace Task03
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int year, day, month;
            User user = new User();

            Console.WriteLine("Enter Name of user:");
            user.Name = Console.ReadLine();

            Console.WriteLine("Enter Surname of user:");
            user.Surname = Console.ReadLine();

            Console.WriteLine("Enter Patronymic of user:");
            user.Patronymic = Console.ReadLine();

            Console.WriteLine("Enter Year of user's born:");
            int.TryParse(Console.ReadLine(), out year);

            Console.WriteLine("Enter Month of user's born:");
            int.TryParse(Console.ReadLine(), out month);

            Console.WriteLine("Enter Day of user's born:");
            int.TryParse(Console.ReadLine(), out day);

            user.DateOfBorn = new DateTime(year, month, day);
            
            Console.WriteLine("Name:\t\t{0}\nSurname:\t{1}\nPatronymic:\t{2}\nDateOfBorn:\t{3:yyyy MM dd}\nAge:\t\t{4}", user.Name, user.Surname, user.Patronymic, user.DateOfBorn, user.Age);
            Console.ReadKey();
        }
    }
}
