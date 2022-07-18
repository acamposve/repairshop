using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class PurchaseOrderLineService : IPurchaseOrderLineService
    {
        private readonly IUnitOfWork _uow;
        public PurchaseOrderLineService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }


        public async Task<IEnumerable<PurchaseOrderLine>> GetAll()
        {
            return await _uow.PurchaseOrderLines.GetAllAsync();
        }

        public async Task<int> AddAsync(PurchaseOrderLine entity)
        {
            return await _uow.PurchaseOrderLines.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await _uow.PurchaseOrderLines.DeleteAsync(id);
        }

        public async Task<PurchaseOrderLine> GetByIdAsync(Guid id)
        {
            return await _uow.PurchaseOrderLines.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(PurchaseOrderLine entity)
        {
            return await _uow.PurchaseOrderLines.UpdateAsync(entity);
        }
    }
}
