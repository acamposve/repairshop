using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface IInvenTranService
    {
        Task<IEnumerable<InvenTran>> GetAll();
        Task<int> AddAsync(InvenTran entity);
        Task<int> DeleteAsync(Guid id);
        Task<InvenTran> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(InvenTran entity);
    }
}
