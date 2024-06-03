using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLogic.Extensions
{
    public static class ServiseCollectionExtensions
    {
        public static void AddLogicServices(this IServiceCollection services)
        {
            services.AddSingleton<IClientRepository, ClientRepository>();
        }
    }
}
