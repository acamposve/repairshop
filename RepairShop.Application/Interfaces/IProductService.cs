using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;
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
        Task<int> AddAsync(ProductRequest entity);
        Task<int> DeleteAsync(int id);
        Task<Product> GetByIdAsync(int id);
        Task<int> UpdateAsync(int id, Product entity);
    }
}
