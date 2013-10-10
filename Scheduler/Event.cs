#region

using System;

#endregion

namespace Scheduler{
    internal struct Event{
        public string Description;
        public DateTime EventDate;
        public bool HasPassed;
        public bool IsCancelled;
    }
}