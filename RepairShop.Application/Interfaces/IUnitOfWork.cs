using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        ISalesOrderRepository SalesOrders { get; }
        ISalesOrderLineRepository SalesOrderLines { get; }
        IVendorRepository Vendors { get; }
    }
}
