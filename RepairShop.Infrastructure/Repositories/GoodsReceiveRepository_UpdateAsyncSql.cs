using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class GoodsReceiveRepository
    {
        public const string UpdateAsyncSql = @"UPDATE [dbo].[GoodsReceive]
                                               SET [Number] = @Number
                                                  ,[Description] = @Description
                                                  ,[GoodsReceiveDate] = @GoodsReceiveDate
                                                  ,[PurchaseOrderId] = @PurchaseOrderId
                                             WHERE [GoodsReceiveId] = @Id";
    }
}
