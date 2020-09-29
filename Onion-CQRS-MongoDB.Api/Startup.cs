using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Onion_CQRS_MongoDB.Services.CommandBus;
using Onion_CQRS_MongoDB.Services.Commands.DI;
using Onion_CQRS_MongoDB.Services.Repository;

namespace Onion_CQRS_MongoDB.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appsettings = new Settings.Appsettings();
            Configuration.Bind(appsettings);

            services.AddControllers();

            var dbContext = new MongoContext(appsettings.MongoDB.ConnectionString, appsettings.MongoDB.Database);
            services.AddSingleton(typeof(MongoContext), dbContext);
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new CommandsModule());
            builder.RegisterModule(new CommandBusModule());
            builder.RegisterModule(new RepositoryModule());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
