using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }


        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _uow.Products.GetAllAsync();
        }

        public async Task<int> AddAsync(Product entity)
        {
            return await _uow.Products.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await _uow.Products.DeleteAsync(id);
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            return await _uow.Products.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(Product entity)
        {
            return await _uow.Products.UpdateAsync(entity);
        }
    }
}
