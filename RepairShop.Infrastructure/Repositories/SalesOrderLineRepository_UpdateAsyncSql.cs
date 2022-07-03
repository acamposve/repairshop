using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class SalesOrderLineRepository
    {
        public const string UpdateAsyncSql = @"UPDATE [dbo].[SalesOrderLine]
                                               SET 
                                                  ,[SalesOrderId] = @SalesOrderId
                                                  ,[ProductId] = @ProductId
                                                  ,[Quantity] = @Quantity
                                                  ,[Price] = @Price
                                                  ,[SubTotal] = @SubTotal
                                                  ,[Discount] = @Discount
                                                  ,[Total] = @Total
                                             WHERE [SalesOrderLineId] = @Id";
    }
}
