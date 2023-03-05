using MicroserviceCalculator.Domain.Core.Commands;
using MicroserviceCalculator.Domain.Core.Events;

namespace MicroserviceCalculator.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Suscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;

    }
}
