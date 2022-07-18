using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface IGoodsReceiveService
    {
        Task<IEnumerable<GoodsReceive>> GetAll();
        Task<int> AddAsync(GoodsReceive entity);
        Task<int> DeleteAsync(Guid id);
        Task<GoodsReceive> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(GoodsReceive entity);
    }
}
