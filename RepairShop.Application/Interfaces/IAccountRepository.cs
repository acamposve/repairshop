using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;
using RepairShop.Core.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Task<AuthenticateResponse> GetByEmailAsync(AuthenticateRequest model, string ipAddress);
    }

}
