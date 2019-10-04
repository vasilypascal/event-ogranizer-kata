using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EventOrganizerKata
{
    public interface IEvent
    {
        string Name { get; set; }
        Period EventPeriod { get; set; }

        void ShowEvent();
        bool ConflictsWith(IEvent otherEvent);
        Period GetConflictPeriod(IEvent otherEvent);

    }
}
