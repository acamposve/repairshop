using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<int> AddAsync(Product entity);
        Task<int> DeleteAsync(Guid id);
        Task<Product> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(Product entity);
    }
}
