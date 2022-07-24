using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAll();
        Task<int> AddAsync(CategoryRequest entity);
        Task<int> DeleteAsync(int id);
        Task<Category> GetByIdAsync(int id);
        Task<int> UpdateAsync(int id, Category entity);
    }
}
