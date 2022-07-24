using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class CategoryRepository
    {
        public const string AddSql = @"INSERT INTO [dbo].[Categories]
                                           ([Name]
                                           ,[Description])
                                     VALUES
                                           (@Name
                                           ,@Description)";
    }
}
