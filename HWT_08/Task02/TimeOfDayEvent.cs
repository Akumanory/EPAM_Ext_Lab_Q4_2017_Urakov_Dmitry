using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public delegate void TimeOfDayEventHandler(TimeOfDayEvent sender, TimeStateEventArgs time);

    //События смены времени
    public class TimeOfDayEvent
    {
        public TimeStateEventArgs time = new TimeStateEventArgs();
        
        public event TimeOfDayEventHandler TimeEvent;

        public void TimeBefore12()
        {
            if (TimeEvent != null &&  time.eventTime != 1)
            {
                time.eventTime = 1;

                TimeEvent(this, time);
            }
        }

        public void TimeBetween12and17()
        {
            if (TimeEvent != null && time.eventTime != 2)
            {
                time.eventTime = 2;

                TimeEvent(this, time);
            }
        }

        public void TimeUnder17()
        {
            if (TimeEvent != null && time.eventTime != 3)
            {
                time.eventTime = 3;

                TimeEvent(this, time);
            }
        }
    }
}
