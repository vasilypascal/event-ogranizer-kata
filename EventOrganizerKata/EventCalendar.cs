using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EventOrganizerKata
{
    class EventCalendar
    {
        List<Event> events = new List<Event>();

        public EventCalendar(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    Event temp = new Event(streamReader.ReadLine());
                    events.Add(temp);
                }
            }
        }
        public void ShowEvents()
        {
            foreach (Event e in events)
                e.ShowEvent();
        }
    }
}
