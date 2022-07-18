using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class GoodsReceiveLineRepository
    {
        public const string UpdateAsyncSql = @"UPDATE [GoodsReceiveLine]
                                               SET [GoodsReceiveId] = @GoodsReceiveId
                                                  ,[PurchaseOrderLineId] = @PurchaseOrderLineId
                                                  ,[ProductId] = @ProductId
                                                  ,[QtyPurchase] = @QtyPurchase
                                                  ,[QtyReceive] = @QtyReceive
                                                  ,[QtyReceived] = @QtyReceived
                                             WHERE [GoodsReceiveLineId] = @Id";
    }
}
