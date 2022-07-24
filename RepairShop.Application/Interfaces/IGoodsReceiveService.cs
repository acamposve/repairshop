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
        Task<int> DeleteAsync(int id);
        Task<GoodsReceive> GetByIdAsync(int id);
        Task<int> UpdateAsync(GoodsReceive entity);
    }
}
