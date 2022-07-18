using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class GoodsReceiveRepository
    {
        public const string DeleteAsyncSql = @"DELETE FROM [GoodsReceive] WHERE GoodsReceiveId = @Id";
    }
}
