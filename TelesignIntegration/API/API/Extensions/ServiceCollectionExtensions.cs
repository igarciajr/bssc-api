using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Reflection;

namespace API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            RegisterServices(services, configuration);

            return services;
        }

        private static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ITelesign, Telesign>();
        }
    }
}
