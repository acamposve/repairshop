using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class CustomerRepository
    {
        public const string UpdateAsyncSql = @"UPDATE [dbo].[Customer]
                                           SET [Name] = @Name
                                            ,[Description] = @Description,
                                            [Phone] = @Phone,
                                            [Email] = @Email,
                                            [Address] = @Address,
                                            [Address2] = @Address2
                                         WHERE [CustomerId] = @ID";


    }
}
