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
        IInvenTranRepository InvenTrans { get; }
        IGoodsReceiveRepository GoodsReceives { get; }
        IGoodsReceiveLineRepository GoodsReceiveLines { get; }
        IProductRepository Products { get; }
        IPurchaseOrderRepository PurchaseOrders { get; }
        IPurchaseOrderLineRepository PurchaseOrderLines { get; }

        ISalesOrderRepository SalesOrders { get; }
        
        ISalesOrderLineRepository SalesOrderLines { get; }
        IVendorRepository Vendors { get; }
    }
}
