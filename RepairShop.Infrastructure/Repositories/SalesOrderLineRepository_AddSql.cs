using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial  class SalesOrderLineRepository
    {
        public const string AddSql = @"INSERT INTO [dbo].[SalesOrderLine]
                                       ([SalesOrderLineId]
                                       ,[SalesOrderId]
                                       ,[ProductId]
                                       ,[Quantity]
                                       ,[Price]
                                       ,[SubTotal]
                                       ,[Discount]
                                       ,[Total])
                                 VALUES
                                       (@SalesOrderLineId
                                       ,@SalesOrderId
                                       ,@ProductId
                                       ,@Quantity
                                       ,@Price
                                       ,@SubTotal
                                       ,@Discount
                                       ,@Total)";

    }
}
