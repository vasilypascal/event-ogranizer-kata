using System;
using System.Collections.Generic;
using System.Text;

namespace EventOrganizerKata
{
    class Event
    {
        string name;
        public Period eventPeriod { get; set; }

        public Event(string _event)
        {
            string[] temp = _event.Split(',');
            name = temp[0];
            eventPeriod.Start = Convert.ToDateTime(temp[1]);
            eventPeriod.End = Convert.ToDateTime(temp[2]);
        }
        public void ShowEvent()
        {
            Console.WriteLine(name + "," + eventPeriod);
        }
        public string GetTimeFrame()
        {
         
            return "";
        }
    }
}
