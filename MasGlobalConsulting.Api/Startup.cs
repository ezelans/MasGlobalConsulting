using AutoMapper;
using MasGlobalConsulting.Api.Profiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MasGlobalConsulting.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(provider => new MapperConfiguration(mc =>
            {
                mc.AddProfile(new EmployeeOutputProfile());
                mc.AddProfile(new RoleOutputProfile());
                mc.AddProfile(new ContractOutputProfile());
                mc.AddProfile(new MonthlyContractOutputProfile());
                mc.AddProfile(new HourlyContractOutputProfile());

            }).CreateMapper());

            services.ConfigureFeaturesServices();

            services.ConfigureSwagger();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseSwaggerDocumentation();
            }

            app.UseCors(builder => builder
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               );

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
