using Microsoft.Extensions.DependencyInjection;
using Premiera.Services.ServiceInterfaces;
using Premiera.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Premiera.Services.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
