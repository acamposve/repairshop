using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface IVendorService
    {
        Task<IEnumerable<Vendor>> GetAll();
        Task<int> AddAsync(Vendor entity);
        Task<int> DeleteAsync(int id);
        Task<Vendor> GetByIdAsync(int id);
        Task<int> UpdateAsync(int id, Vendor entity);
    }
}
