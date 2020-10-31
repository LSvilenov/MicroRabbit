using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;

using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        void Publish<T>(T @event) where T : Event;

        Task SendCommand<T>(T command) where T : Command;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
