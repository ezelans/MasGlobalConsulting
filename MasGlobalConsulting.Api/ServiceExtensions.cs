using MasGlobalConsulting.Data;
using MasGlobalConsulting.Data.Repositories;
using MasGlobalConsulting.Data.Repositories.Contracts;
using MasGlobalConsulting.Engine.Services;
using MasGlobalConsulting.Engine.Services.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace MasGlobalConsulting.Api
{
    public static class ServiceExtensions
    {
        public static void ConfigureFeaturesServices(this IServiceCollection services)
        {
            #region Services

            services.AddTransient<IEmployeesService, EmployeesService>();

            #endregion

            #region Repositories

            services.AddTransient<IFacadeRepository, FacadeRepository>();
            services.AddTransient<IEmployeesRepository, EmployeesRepository>();

            #endregion
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
            // Set the comments path for the Swagger JSON and UI.
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("v1/swagger.json", "MySite");
            });

            return app;
        }
    }
}