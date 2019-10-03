using System;
using System.Collections.Generic;
using System.Text;

namespace EventOrganizerKata
{
    class Period
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Period(Period period)
        {
            Start = period.Start;
            End = period.End;
        }
        public void ShowPeriod()
        {
            Console.WriteLine(Start + " - " + End);
        }
        public bool IntersectsWith (Period otherPeriod)
        {
            return !(this.Start > otherPeriod.End || this.End < otherPeriod.Start);
        }
    }
}
