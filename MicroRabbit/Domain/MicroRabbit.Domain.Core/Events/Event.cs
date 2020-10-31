using System;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        protected Event()
        {
            this.TimeStamp = DateTime.UtcNow;
        }

        public DateTime TimeStamp { get; protected set; }
    }
}
