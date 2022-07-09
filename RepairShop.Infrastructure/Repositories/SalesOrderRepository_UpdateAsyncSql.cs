using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class SalesOrderRepository
    {
        public const string UpdateAsyncSql = @"UPDATE [SalesOrder]
                                               SET [Number] = @Number
                                                  ,[Description] = @Description
                                                  ,[SalesOrderDate] = @SalesOrderDate
                                                  ,[CustomerId] = @CustomerId
                                             WHERE [SalesOrderId] = @Id";
    }
}
