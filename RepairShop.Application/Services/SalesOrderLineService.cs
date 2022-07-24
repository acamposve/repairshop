using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class SalesOrderLineService : ISalesOrderLineService
    {
        private readonly IUnitOfWork _uow;
        public SalesOrderLineService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<IEnumerable<SalesOrderLine>> GetAll()
        {
            return await _uow.SalesOrderLines.GetAllAsync();
        }

        public async Task<int> AddAsync(SalesOrderLine entity)
        {
            return await _uow.SalesOrderLines.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _uow.SalesOrderLines.DeleteAsync(id);
        }

        public async Task<SalesOrderLine> GetByIdAsync(int id)
        {
            return await _uow.SalesOrderLines.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(SalesOrderLine entity)
        {
            return await _uow.SalesOrderLines.UpdateAsync(entity);
        }
    }
}
