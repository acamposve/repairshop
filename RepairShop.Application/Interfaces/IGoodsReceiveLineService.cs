using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface IGoodsReceiveLineService
    {
        Task<IEnumerable<GoodsReceiveLine>> GetAll();
        Task<int> AddAsync(GoodsReceiveLine entity);
        Task<int> DeleteAsync(Guid id);
        Task<GoodsReceiveLine> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(GoodsReceiveLine entity);
    }
}
