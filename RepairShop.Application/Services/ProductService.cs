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

        public async Task<int> AddAsync(ProductRequest request)
        {
            var entity = new Product
            {
                Name = request.Name,
                Description = request.Description,
                PricePurchase = request.PricePurchase,
                PriceSell = request.PriceSell
            };
            return await _uow.Products.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _uow.Products.DeleteAsync(id);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _uow.Products.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(int id, Product entity)
        {
            entity.ProductId = id;
            return await _uow.Products.UpdateAsync(entity);
        }
    }
}
