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
        Task<int> DeleteAsync(int id);
        Task<SalesOrderLine> GetByIdAsync(int id);
        Task<int> UpdateAsync(SalesOrderLine entity);
    }
}
