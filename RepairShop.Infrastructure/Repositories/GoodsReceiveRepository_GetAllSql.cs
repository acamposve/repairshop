using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class GoodsReceiveRepository
    {
        public const string GetAllSql = @"SELECT [GoodsReceiveId]
                                              ,[Number]
                                              ,[Description]
                                              ,[GoodsReceiveDate]
                                              ,[PurchaseOrderId]
                                          FROM [GoodsReceive]";
    }
}
