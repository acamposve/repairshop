using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class PurchaseOrderLineRepository
    {
        public const string UpdateAsyncSql = @"UPDATE [PurchaseOrderLine]
                                               SET [PurchaseOrderId] = @PurchaseOrderId
                                                  ,[ProductId] = @ProductId
                                                  ,[Quantity] = @Quantity
                                                  ,[Price] = @Price
                                                  ,[SubTotal] = @SubTotal
                                                  ,[Discount] = @Discount
                                                  ,[Total] = @Total
                                             WHERE [PurchaseOrderLineId] = @Id";
    }
}
