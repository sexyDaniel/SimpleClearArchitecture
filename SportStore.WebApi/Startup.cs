using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SportStore.Application;
using SportStore.Persistence;
using SportStore.Application.Common.Mapping;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using SportStore.Application.Interfaces;

namespace SportStore.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(conf =>
            {
                conf.AddProfile(new AssemblyMappingProfile(Assembly.GetExecutingAssembly()));
                conf.AddProfile(new AssemblyMappingProfile(typeof(IDbContext).Assembly));
            });

            services.AddControllers();
            services.AddAplication();
            services.AddPersistence(Configuration);
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(config=> 
            {
                config.RoutePrefix = string.Empty;
                config.SwaggerEndpoint("swagger/v1/swagger.json", "SportStore WebApi");
            });
            app.UseRouting();
            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
