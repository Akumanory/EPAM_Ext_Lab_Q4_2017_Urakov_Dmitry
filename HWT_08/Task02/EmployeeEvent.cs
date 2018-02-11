using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02 
{
    public delegate void EmployeeEventHandler(EmployeeEvent sender, Person person, TimeStateEventArgs time);
   
    //События прихода и ухода
    public class EmployeeEvent 
    {
        TimeOfDayEvent timeOfDay = new TimeOfDayEvent();

        private bool employeeState = false;

        public bool State
        {
            get {return employeeState; }
        }

        public event EmployeeEventHandler Employee;

        public void EmployeeCame(Person person)
        {
            if (Employee != null)
            {
                employeeState = true;
                Employee(this, person, timeOfDay.time);
            }
            
        }

        public void EmployeeOut(Person person)
        {
            if (Employee != null)
            {
                employeeState = false;
                Employee(this, person, timeOfDay.time);
            }
            
        }
    }
}
