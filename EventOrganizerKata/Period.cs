using System;

namespace EventOrganizerKata
{
    public class Period
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Period(DateTime start, DateTime end)
        {
            if (start > end)
            {
                throw new Exception("Invalid period edges");
            }
            Start = start;
            End = end;
        }
        public Period()
        {

        }

        public bool ConflictsWith(Period otherPeriod)
        {
            if (otherPeriod == null)
                throw new ArgumentNullException("Period can not be null");

            if (End <= otherPeriod.Start || Start >= otherPeriod.End)
                return false;
            return true;
        }

        public Period GetIntersectionsPeriodWith(Period otherPeriod)
        {
            if (Start < otherPeriod.Start && End > otherPeriod.Start && End <= otherPeriod.End)
            {
                return new Period(otherPeriod.Start, End);
            }
            else if (Start < otherPeriod.Start && End > otherPeriod.End)
            {
                return new Period(otherPeriod.Start, otherPeriod.End);
            }
            else if (Start >= otherPeriod.Start && End > otherPeriod.End)
            {
                return new Period(Start, otherPeriod.End);
            }
            else if (Start >= otherPeriod.Start && End > otherPeriod.Start && End <= otherPeriod.End)
            {
                return new Period(Start, End);
            }
            throw new Exception("No intersection was found");

        }
    }
}
