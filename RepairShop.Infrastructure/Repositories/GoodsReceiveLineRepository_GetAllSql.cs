using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class GoodsReceiveLineRepository
    {
        public const string GetAllSql = @"SELECT [GoodsReceiveLineId]
                                              ,[GoodsReceiveId]
                                              ,[PurchaseOrderLineId]
                                              ,[ProductId]
                                              ,[QtyPurchase]
                                              ,[QtyReceive]
                                              ,[QtyReceived]
                                          FROM [GoodsReceiveLine]";
    }
}
