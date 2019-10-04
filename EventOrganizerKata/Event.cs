using System;
using System.Collections.Generic;
using System.Text;

namespace EventOrganizerKata
{
    public class Event : IEvent
    {
        public string Name { get; set; }
        public Period EventPeriod { get; set; }

        public Event(string _event)
        {
            string[] temp = _event.Split(',');
            Name = temp[0];
            EventPeriod = new Period(Convert.ToDateTime(temp[1]), Convert.ToDateTime(temp[2]));

            //else throw new Exception("Line was not type of \"Event\"");
        }

        public Event(string name, Period eventPeriod)
        {
            Name = name;
            this.EventPeriod = eventPeriod;
        }

        public void ShowEvent()
        {
            Console.WriteLine(Name + ", " + EventPeriod.Start + "," + EventPeriod.End);
        }
        public bool ConflictsWith(IEvent otherEvent)
        {
            if (EventPeriod.ConflictsWith(otherEvent.EventPeriod))
                return true;
            return false;
        }
        public Period GetConflictPeriod(IEvent otherEvent)
        {
            return EventPeriod.GetIntersectionsPeriodWith(otherEvent.EventPeriod);
        }
    }
}
