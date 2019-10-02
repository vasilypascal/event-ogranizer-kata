using System;
using System.Collections.Generic;
using System.Text;

namespace EventOrganizerKata
{
    class Event
    {
        string name;
        DateTime startDate;
        DateTime finishDate;

        public Event(string events)
        {
            string[] temp = events.Split(',');
            name = temp[0];
            startDate = Convert.ToDateTime(temp[1]);
            finishDate = Convert.ToDateTime(temp[2]);
        }
        public void ShowEvent()
        {
            Console.WriteLine(name + "," + startDate + "," + finishDate);
        }
    }
}
