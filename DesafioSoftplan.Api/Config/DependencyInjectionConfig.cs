using DesafioSoftplan.Services.Services;
using DesafioSoftplan.Services.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Config
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IJurosService, JurosService>();
        }
    }
}
