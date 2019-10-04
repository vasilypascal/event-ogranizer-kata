using System;
using System.Collections.Generic;

namespace EventOrganizerKata
{
    class Program
    {
        static void Main(string[] args)
        {
            //EventCalendar events = new EventCalendar(@"C:\Users\vpascal\.NET Projects\event-ogranizer-kata\event-ogranizer-kata\EventOrganizerKata\Calendar1.txt");
            //events.ShowEvents();

            //DateTime event1 = new DateTime(2009,08,15, 12,32,00);
            //DateTime event2 = new DateTime(2009, 08, 15, 14, 32, 00);
            //DateTime event3 = new DateTime(2009, 08, 15, 13, 32, 00);
            //DateTime event4 = new DateTime(2009, 08, 15, 17, 32, 00);
            //Console.WriteLine(DateTime.Compare(event1, event2));

            List<IEvent> events = CalendarConverter.ToListofEvents(@"C:\Users\vpascal\.NET Projects\event-ogranizer-kata\event-ogranizer-kata\EventOrganizerKata\Calendar1.txt");
            EventCalendar eventCalendar = new EventCalendar(events);
            eventCalendar.ShowEvents();

            eventCalendar.ShowConflicts();

            Console.ReadKey();
        }
    }
}
