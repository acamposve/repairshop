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
        Task<int> DeleteAsync(int id);
        Task<GoodsReceiveLine> GetByIdAsync(int id);
        Task<int> UpdateAsync(GoodsReceiveLine entity);
    }
}
