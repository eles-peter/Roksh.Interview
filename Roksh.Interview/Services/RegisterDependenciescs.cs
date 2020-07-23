using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roksh.Interview.Services
{
    public static class RegisterDependencies
    {
        public static void RegisterServiceDependencies(this IServiceCollection services)
        {
            //services.AddTransient<IOrcService, OrcService>();
            //services.AddTransient<IHordeService, HordeService>();
        }

    }
}
