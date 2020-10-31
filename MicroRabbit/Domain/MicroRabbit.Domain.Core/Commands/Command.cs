using MicroRabbit.Domain.Core.Events;

using System;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        protected Command()
        {
            this.TimeStamp = DateTime.UtcNow;
        }

        public DateTime TimeStamp { get; protected set; }
    }
}
