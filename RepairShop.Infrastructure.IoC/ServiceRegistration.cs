using Microsoft.Extensions.DependencyInjection;
using RepairShop.Application.Interfaces;
using RepairShop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.IoC
{
    public static class ServiceRegistration
    {
        public static void AddServicesInfrastructure(this IServiceCollection services)
        {
            //repositories
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ISalesOrderRepository, SalesOrderRepository>();
            services.AddScoped<ISalesOrderLineRepository, SalesOrderLineRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IVendorRepository, VendorRepository>();
        }
    }
}
