using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class PurchaseOrderRepository
    {
        public const string DeleteAsyncSql = @"DELETE FROM [PurchaseOrder] WHERE PurchaseOrderId = @Id";
    }
}
