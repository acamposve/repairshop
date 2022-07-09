using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class SalesOrderService : ISalesOrderService
    {
        private readonly IUnitOfWork _uow;
        public SalesOrderService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<IEnumerable<SalesOrder>> GetAll()
        {
            return await _uow.SalesOrders.GetAllAsync();
        }

        public async Task<int> AddAsync(SalesOrder entity)
        {
            return await _uow.SalesOrders.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await _uow.SalesOrders.DeleteAsync(id);
        }

        public async Task<SalesOrder> GetByIdAsync(Guid id)
        {
            return await _uow.SalesOrders.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(SalesOrder entity)
        {
            return await _uow.SalesOrders.UpdateAsync(entity);
        }
    }
}
