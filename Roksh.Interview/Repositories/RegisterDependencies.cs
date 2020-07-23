using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roksh.Interview.Repositories
{
    public static class RegisterDependencies
    {
        public static void RegisterRepositoryDependencies(this IServiceCollection services)
        {
            //services.AddTransient<IOrcRepository, OrcRepository>();
            //services.AddTransient<IHordeRepository, HordeRepository>();

        }
    }
}
