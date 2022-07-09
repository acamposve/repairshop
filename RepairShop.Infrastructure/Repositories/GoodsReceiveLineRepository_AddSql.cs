using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class GoodsReceiveLineRepository
    {
        public const string AddSql = @"INSERT INTO [GoodsReceiveLine]
                                           ([GoodsReceiveLineId]
                                           ,[GoodsReceiveId]
                                           ,[PurchaseOrderLineId]
                                           ,[ProductId]
                                           ,[QtyPurchase]
                                           ,[QtyReceive]
                                           ,[QtyReceived])
                                     VALUES
                                           (@GoodsReceiveLineId
                                           ,@GoodsReceiveId
                                           ,@PurchaseOrderLineId
                                           ,@ProductId
                                           ,@QtyPurchase
                                           ,@QtyReceive
                                           ,@QtyReceived)";
    }
}
