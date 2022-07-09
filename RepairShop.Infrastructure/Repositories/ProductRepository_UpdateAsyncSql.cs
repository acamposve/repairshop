using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class ProductRepository
    {
        public const string UpdateAsyncSql = @"UPDATE [Product]
                                               SET [Name] = @Name
                                                  ,[Description] = @Description
                                                  ,[PriceSell] = @PriceSell
                                                  ,[PricePurchase] = @PricePurchase
                                             WHERE [ProductId] = @Id";
    }
}
