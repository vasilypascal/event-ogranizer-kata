using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EventOrganizerKata
{
    class EventCalendar : ICalendar
    {
        List<IEvent> events;

        public EventCalendar(List<IEvent> events)
        {
            if (events != null)
            {
                this.events = events;
            }
        }
        public void ShowEvents()
        {
            foreach (IEvent e in events)
                e.ShowEvent();
        }
        public void ShowConflicts()
        {
            int conflictIndex = 1;
            for (int i = 0; i < events.Count; i++)
            {
                for (int k = i + 1; k < events.Count; k++)
                {
                    if (events[i].ConflictsWith(events[k]))
                    {
                        Period conflict = events[i].GetConflictPeriod(events[k]);
                        Console.WriteLine("Conflict " + conflictIndex++ + ": Event " + events[i].Name + " conflicts with event " + events[k].Name +
                            " between period " + conflict.Start.ToString("hh:mm dd/MM") + " and "
                            + conflict.End.ToString("hh:mm dd/MM"));
                    }
                }
            }

        }
    }
}
