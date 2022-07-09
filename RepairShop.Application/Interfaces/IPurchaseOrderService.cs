using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface IPurchaseOrderService
    {
        Task<IEnumerable<PurchaseOrder>> GetAll();

        Task<int> AddAsync(PurchaseOrder entity);
        Task<int> DeleteAsync(Guid id);
        Task<PurchaseOrder> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(PurchaseOrder entity);
    }
}
