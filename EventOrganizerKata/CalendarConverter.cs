using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EventOrganizerKata
{
    public static class CalendarConverter
    {
        //StreamReader streamReader;
        //public CalendarConverter(StreamReader streamReader)
        //{
        //    this.streamReader = streamReader;
        //}
        public static List<IEvent> ToListofEvents(string path)
        {
            List<IEvent> events = new List<IEvent>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    Event tempEvent = new Event(streamReader.ReadLine());
                    events.Add(tempEvent);
                }
            }
            return events;
        }
    }
}
