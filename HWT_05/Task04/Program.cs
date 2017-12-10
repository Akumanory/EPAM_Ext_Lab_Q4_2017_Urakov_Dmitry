namespace Task04
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            MyString str = new MyString();
            string line = "saSAD sadsdsad123sa2341sadSDWsdsf";

            Console.WriteLine("String to char array:\nString = {0}\nChar array: ", line);

            foreach (var chars in str.ToCharArray(line))
            {
                Console.Write("{0} ", chars);
            }

            Console.WriteLine("\n\nString to upper:\nString = {0}\nTo upper = {1}", line, str.ToUpper(line));

            Console.WriteLine("\nString to lower:\nString = {0}\nTo lower = {1}", line, str.ToLower(line));

            Console.WriteLine("\nString remove:\nString = {0}\nRemove from 4 to 13 char  = {1}", line, str.Remove(line, 4, 9));

            Console.WriteLine("\nString replace:\nString = {0}\nReplace 'a' to 'Z' = {1}", line, str.Replace(line, 'a', 'Z'));

            Console.ReadKey();
        }
    }
}
