using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class VendorRepository
    {
        public const string GetByIdAsyncSql = @"SELECT [VendorId]
                                              ,[Name]
                                              ,[Description]
                                              ,[Phone]
                                              ,[Email]
                                              ,[Address]
                                              ,[Address2]
                                               FROM [Vendor] WHERE [VendorId] = @Id";
    }
}
