using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Office
    {
        public TimeOfDayEvent timeEvent;
        public EmployeeEvent employeeEvent;
        public MessageGreet GreetByUs;
        public MessageBye ByeByUs;
        

        public Office()
        {
            GreetByUs = null;
            ByeByUs = null;
            timeEvent = new TimeOfDayEvent();
            employeeEvent = new EmployeeEvent();
            

            timeEvent.TimeEvent += Time_State;
            employeeEvent.Employee += Employee_State;
        }

        //Обработка события смены времени
        private void Time_State(TimeOfDayEvent sender, TimeStateEventArgs time)
        {

            if (sender == timeEvent)
            {
                if (time.eventTime == 1)
                {
                    Console.WriteLine("[Time of day is before 12]");

                }

                if (time.eventTime == 2)
                {
                    Console.WriteLine("[Time of day is between 12 and 17]");
                }

                if (time.eventTime == 3)
                {
                    Console.WriteLine("[Time of day is under 17]");
                }
            }
        }

        //Обработка прихода и ухода сотрудника
        private void Employee_State(EmployeeEvent sender, Person person, TimeStateEventArgs time)
        {
            MessageGreet GreetByPerson = new MessageGreet(person.Greet);
            MessageBye ByeByPerson = new MessageBye(person.Bye);

            

            if (sender == employeeEvent)
            {
                if (employeeEvent.State == true)
                {
                    Console.WriteLine("[{0} came to office]", person.Name);

                    if (GreetByUs != null & GreetByUs != GreetByPerson)
                    {
                        GreetByUs(person, time);
                    }

                    GreetByUs += GreetByPerson;
                    ByeByUs += ByeByPerson;
                }

                if (employeeEvent.State == false)
                {
                    Console.WriteLine("[{0} leave from office]", person.Name);

                    ByeByUs -= ByeByPerson;

                    if (ByeByUs != null & ByeByUs != ByeByPerson)
                    {
                        ByeByUs(person);
                    }

                    
                }
            }

            

        }
    }

    
}
