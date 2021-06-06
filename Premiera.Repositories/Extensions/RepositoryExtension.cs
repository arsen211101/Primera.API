using Microsoft.Extensions.DependencyInjection;
using Premiera.Repositories.Repository;
using Premiera.Repositories.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Premiera.Repositories.Extensions
{
   public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
             services.AddScoped<IProductRepository, ProductRepository>();
             return services;
        }

    }
}
