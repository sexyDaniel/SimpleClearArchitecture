using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SportStore.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Persistence
{
    public static class DI
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IDbContext, AppDbContext>();
            return services;
        }
    }
}
