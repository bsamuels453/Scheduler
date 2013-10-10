#region

using System;

#endregion

namespace Scheduler{
    internal class Event{
        public string Description;
        public DateTime EventDate;
        public bool HasPassed;
        public bool IsCancelled;
    }

    internal class DisplayEvent{
        public string Description;
        public string Date;
        public string Time;
        public string TimeUntil;

    }
}