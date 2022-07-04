using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface ISalesOrderLineService
    {
        Task<IEnumerable<SalesOrderLine>> GetAll();

        Task<int> AddAsync(SalesOrderLine entity);
        Task<int> DeleteAsync(Guid id);
        Task<SalesOrderLine> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(SalesOrderLine entity);
    }
}
