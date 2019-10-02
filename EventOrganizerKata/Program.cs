using System;

namespace EventOrganizerKata
{
    class Program
    {
        static void Main(string[] args)
        {
            EventCalendar events = new EventCalendar(@"C:\Users\vpascal\.NET Projects\event-ogranizer-kata\event-ogranizer-kata\EventOrganizerKata\Calendar1.txt");
            events.ShowEvents();

            Console.ReadKey();
        }
    }
}
