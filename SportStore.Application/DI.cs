using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace SportStore.Application
{
    public static class DI
    {
        public static IServiceCollection AddAplication(this IServiceCollection services) 
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
