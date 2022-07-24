using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class AccountRepository
    {
        public const string GetByEmailAsyncSql = @"SELECT [id]
                                                      ,[FirstName]
                                                      ,[LastName]
                                                      ,[Username]
                                                      ,[Role]
                                                      ,[Password]
                                                      ,[Email]
                                                  FROM [dbo].[Users] WHERE [Email] = @Email and [Password] ) @Password";

    }
}
