using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class InvenTranRepository
    {
        public const string DeleteAsyncSql = @"DELETE FROM [InvenTran] WHERE InvenTranId = @Id";
    }
}
