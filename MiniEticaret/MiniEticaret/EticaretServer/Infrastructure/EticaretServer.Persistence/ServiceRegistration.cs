using Microsoft.EntityFrameworkCore;
using EticaretServer.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using EticaretServer.Application.Repositories.Customers;
using EticaretServer.Persistence.Repositories.Customers;
using EticaretServer.Application.Repositories.Orders;
using EticaretServer.Persistence.Repositories.Orders;
using EticaretServer.Application.Repositories.Products;
using EticaretServer.Persistence.Repositories.Products;

namespace EticaretServer.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<EticaretServerContext>(options=>options.UseNpgsql("User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=EticaretServerNEWwwDB;"));


            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

        }
    }
}
