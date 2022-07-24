using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface IPurchaseOrderLineService
    {
        Task<IEnumerable<PurchaseOrderLine>> GetAll();

        Task<int> AddAsync(PurchaseOrderLine entity);
        Task<int> DeleteAsync(int id);
        Task<PurchaseOrderLine> GetByIdAsync(int id);
        Task<int> UpdateAsync(PurchaseOrderLine entity);
    }
}
