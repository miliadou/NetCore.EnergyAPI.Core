using Microsoft.Extensions.DependencyInjection;
using NetCore.Energy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore.Energy.Core.Implementation
{
    public static class EnergyServiceDIExtensions
    {
        public static IServiceCollection AddEnergyService(this IServiceCollection services)
        {
            services.AddScoped<IHttpClientService, HttpClientService>();
            services.AddScoped<IEnergyService, EnergyService>();
            services.AddHttpClient("energy");
            return services;
        }
    }
}
