using MediatR;
using MicroserviceCalculator.Domain.Core.Bus;
using MicroserviceCalculator.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroserviceCalculator.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });
        }
    }
}
