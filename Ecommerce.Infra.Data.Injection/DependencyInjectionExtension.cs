using Ecommerce.Domain.Interfaces.Repository;
using Ecommerce.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infra.Data.Injection
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            //Services

            //Repositories
            services.AddTransient<IClienteRepository, ClienteRepository>();

            return services;
        }
    }
}