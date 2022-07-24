using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class CategoryRepository
    {
        public const string GetAllSql = @"SELECT [Id]
                                              ,[Name]
                                              ,[Description]
                                          FROM [Categories]";
    }
}
