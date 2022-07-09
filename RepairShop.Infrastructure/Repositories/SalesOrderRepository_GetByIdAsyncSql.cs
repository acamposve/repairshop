using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class SalesOrderRepository
    {
        public const string GetByIdAsyncSql = @"SELECT [SalesOrderId]
                                                  ,[Number]
                                                  ,[Description]
                                                  ,[SalesOrderDate]
                                                  ,[CustomerId]
                                                FROM [SalesOrder] WHERE [SalesOrderId] = @Id";
    }
}
