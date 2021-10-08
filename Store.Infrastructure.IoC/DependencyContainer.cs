using Microsoft.Extensions.DependencyInjection;
using Store.Application.Interfaces;
using Store.Application.Services;
using Store.Domain.Interfaces;
using Store.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Store.Application
            services.AddScoped<IProductService, ProductService>();

            //Store.Domain.Interfaces e Store.Infra.Data.Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
        }

    }
}
