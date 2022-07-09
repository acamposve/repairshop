using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class ProductRepository
    {
        public const string GetByIdAsyncSql = @"SELECT [ProductId]
                                                      ,[Name]
                                                      ,[Description]
                                                      ,[PriceSell]
                                                      ,[PricePurchase]
                                                  FROM [Product]
                                                WHERE [ProductId] = @Id";

    }
}
