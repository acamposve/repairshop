using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class CategoryService : ICategoryService
    {

        private IUnitOfWork _uow;
        public CategoryService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _uow.Categories.GetAllAsync();
        }

        public async Task<int> AddAsync(CategoryRequest entity)
        {
            var category = new Category
            {
                Name = entity.Name,
                Description = entity.Description,

            };

            return await _uow.Categories.AddAsync(category);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _uow.Categories.DeleteAsync(id);
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _uow.Categories.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(int id, Category entity)
        {
            entity.Id = id;
            return await _uow.Categories.UpdateAsync(entity);
        }
    }
}
