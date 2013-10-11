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

    internal class DisplayEvent : IEquatable<DisplayEvent>{
        public string Date;
        public string Description;
        public DateTime EventDateTime;
        public string Time;
        public string TimeUntil;

        #region IEquatable<DisplayEvent> Members

        public bool Equals(DisplayEvent other){
            if (this.EventDateTime == other.EventDateTime)
                return true;
            return false;
        }

        #endregion
    }
}