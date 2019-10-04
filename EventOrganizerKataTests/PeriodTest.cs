using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EventOrganizerKata;

namespace EventOrganizerKataTests
{
    public class PeriodTest
    {
        [Fact]
        public void ConflictsWith_ReturnsTrue_AfterCheckingTwoPeriods()
        {
            bool expected = true;

            Period periodA = new Period(new DateTime(2019, 05, 05, 10, 30, 00), new DateTime(2019, 05, 05, 10, 50, 00));
            Period periodB = new Period(new DateTime(2019, 05, 05, 10, 10, 00), new DateTime(2019, 05, 05, 10, 40, 00));

            bool actual = periodA.ConflictsWith(periodB);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConflictsWith_ReturnsFalse_AfterCheckingTwoPeriods()
        {
            bool expected = false;

            Period periodA = new Period(new DateTime(2019, 05, 05, 10, 30, 30), new DateTime(2019, 05, 05, 11, 00, 00));
            Period periodB = new Period(new DateTime(2019, 05, 05, 10, 10, 00), new DateTime(2019, 05, 05, 10, 30, 00));

            bool actual = periodA.ConflictsWith(periodB);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConflictsWith_ReturnsArgumentNullException_AfterCheckingNullPeriod()
        {
            Period periodThis = new Period(new DateTime(2019, 05, 05, 10, 30, 30), new DateTime(2019, 05, 05, 11, 30, 30));
            Period periodOther = new Period();
            periodOther = null;

            Action act = () => periodThis.ConflictsWith(periodOther);

            Assert.Throws<ArgumentNullException>("Period can not be null", act);
        }

        [Fact]
        public void GetIntersectionsPeriodWith_ReturnsValidPeriod_AfterCheckingTwoPeriods()
        {
            Period expected = new Period(new DateTime(2019, 05, 05, 12, 00, 00), new DateTime(2019, 05, 05, 13, 00, 00));

            Period periodA = new Period(new DateTime(2019, 05, 05, 10, 30, 30), new DateTime(2019, 05, 05, 13, 00, 00));
            Period periodB = new Period(new DateTime(2019, 05, 05, 12, 00, 00), new DateTime(2019, 05, 05, 19, 00, 00));

            Period actual = periodA.GetIntersectionsPeriodWith(periodB);

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetIntersectionsPeriodWith_ThrowsNoConflictWasFoundException_AfterCheckingTwoPeriods()
        {
            Period periodThis = new Period(new DateTime(2019, 05, 05, 10, 30, 30), new DateTime(2019, 05, 05, 11, 30, 30));
            Period periodOther = new Period(new DateTime(2019, 05, 05, 20, 30, 30), new DateTime(2019, 05, 05, 21, 30, 30));

            Action act = () => periodThis.GetIntersectionsPeriodWith(periodOther);

            Assert.Throws<Exception>(act);
        }
    }
}
