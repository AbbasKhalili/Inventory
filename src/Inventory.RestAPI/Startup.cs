using Autofac;
using Framework.ServiceHost;
using Framework.ServiceHost.ExceptionHandling;
using Inventory.Bootstrap;
using Inventory.DBMigration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Inventory.RestAPI
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private IConfiguration Configuration { get; }
        private HostInformation _hostConfig;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            _env = env;
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Inventory.RestAPI", Version = "v1" });
            }); 
            
            _hostConfig = new HostInformation();
            Configuration.Bind("HostInformation", _hostConfig);
            services.AddSingleton(_hostConfig);

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    cors => cors.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            services.AddMvc();

            services.AddFluentMigrator(_hostConfig.DBConnection, typeof(_0001_Category).Assembly);
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.AddFramework();
            builder.AddModule(_hostConfig.DBConnection);
            builder.AddNLog();
        }

        public void Configure(IApplicationBuilder app)
        {
            if (_env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Inventory.RestAPI v1"));
            }

            app.ApplicationServices.RunMigration();


            if (_env.IsProduction())
                app.ConfigExceptionMiddleware(ErrorResource.ResourceManager);

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
