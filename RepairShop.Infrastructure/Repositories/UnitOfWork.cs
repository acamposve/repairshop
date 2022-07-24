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
            ICategoryRepository categoryRepository,
            IGoodsReceiveRepository goodsReceiveRepository,
            IGoodsReceiveLineRepository goodsReceiveLineRepository,
            IInvenTranRepository invenTranRepository,
            ICustomerRepository customerRepository,
            IProductRepository productRepository,
            IPurchaseOrderRepository purchaseOrderRepository,
            IPurchaseOrderLineRepository purchaseOrderLineRepository,
            ISalesOrderRepository salesOrderRepository,
            ISalesOrderLineRepository salesOrderLineRepository,
            IVendorRepository vendorRepository)
        {
            Categories = categoryRepository;
            GoodsReceives = goodsReceiveRepository;
            GoodsReceiveLines = goodsReceiveLineRepository;
            InvenTrans = invenTranRepository;
            Customers = customerRepository;
            Products = productRepository;
            PurchaseOrders = purchaseOrderRepository;
            PurchaseOrderLines = purchaseOrderLineRepository;
            SalesOrders = salesOrderRepository;
            SalesOrderLines = salesOrderLineRepository;
            Vendors = vendorRepository;
        }
        public ICategoryRepository Categories { get; }
        public IGoodsReceiveRepository GoodsReceives { get; }
        public IGoodsReceiveLineRepository GoodsReceiveLines { get; }
        public IInvenTranRepository InvenTrans { get; }
        public ICustomerRepository Customers { get; }
        public IProductRepository Products { get; }
        public IPurchaseOrderRepository PurchaseOrders { get; }
        public IPurchaseOrderLineRepository PurchaseOrderLines { get; }
        public ISalesOrderRepository SalesOrders { get; }
        public ISalesOrderLineRepository SalesOrderLines { get; }
        public IVendorRepository Vendors { get; }
    }
}
