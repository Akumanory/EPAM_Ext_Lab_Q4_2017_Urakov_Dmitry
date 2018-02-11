using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public delegate void MessageGreet(Person person, TimeStateEventArgs time);
    public delegate void MessageBye(Person person);

    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public void Greet(Person person, TimeStateEventArgs time)
        {
            if (time.eventTime == 1)
            {
                Console.WriteLine("'Good morning, {0}', {1} said.", person.Name, Name);
            }

            if (time.eventTime == 2)
            {
                Console.WriteLine("'Good afternoon, {0}', {1} said.", person.Name, Name);
            }

            if (time.eventTime == 3)
            {
                Console.WriteLine("'Good evening, {0}', {1} said.", person.Name, Name);
            }
        }

        public void Bye(Person person)
        {
            Console.WriteLine("'Goodbye, {0}', {1} said.", person.Name, Name);
        }
    }
}
