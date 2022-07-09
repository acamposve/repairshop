using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class GoodsReceiveRepository
    {
        public const string AddSql = @"INSERT INTO [dbo].[GoodsReceive]
                                           ([GoodsReceiveId]
                                           ,[Number]
                                           ,[Description]
                                           ,[GoodsReceiveDate]
                                           ,[PurchaseOrderId])
                                     VALUES
                                           (@GoodsReceiveId
                                           ,@Number
                                           ,@Description
                                           ,@GoodsReceiveDate
                                           ,@PurchaseOrderId)";
    }
}
