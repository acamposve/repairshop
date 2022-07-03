using RepairShop.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            ICustomerRepository customerRepository,
            IVendorRepository vendorRepository)
        {
            Customers = customerRepository;
            Vendors = vendorRepository;
        }
        public ICustomerRepository Customers { get; }
        public IVendorRepository Vendors { get; }
    }
}
