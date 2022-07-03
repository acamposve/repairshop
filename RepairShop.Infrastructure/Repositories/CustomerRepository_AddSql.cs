using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class CustomerRepository
    {

        public const string AddSql = "INSERT INTO [dbo].[Customer] ([CustomerId],[Name],[Description],[Phone],[Email],[Address],[Address2]) VALUES (@CustomerId,@Name,@Description,@Phone, @Email, @Address, @Address2)";
    }
}
