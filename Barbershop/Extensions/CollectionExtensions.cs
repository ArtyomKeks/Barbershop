using Barbershop.Features;
using BarbershopLogic.Extensions;
using Microsoft.AspNetCore.Identity;

namespace Barbershop.Extensions
{
    public static class CollectionExtensions
    {
        public static void AddWebServices(this IServiceCollection services)
        {
            services.AddLogicServices();

            services.AddTransient<IClientManager, ClientManager>();
        }
    }
}
