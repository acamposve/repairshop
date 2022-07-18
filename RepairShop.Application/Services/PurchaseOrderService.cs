using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.Application.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IUnitOfWork _uow;
        public PurchaseOrderService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }


        public async Task<IEnumerable<PurchaseOrder>> GetAll()
        {
            return await _uow.PurchaseOrders.GetAllAsync();
        }

        public async Task<int> AddAsync(PurchaseOrder entity)
        {
            return await _uow.PurchaseOrders.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await _uow.PurchaseOrders.DeleteAsync(id);
        }

        public async Task<PurchaseOrder> GetByIdAsync(Guid id)
        {
            return await _uow.PurchaseOrders.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(PurchaseOrder entity)
        {
            return await _uow.PurchaseOrders.UpdateAsync(entity);
        }
    }
}
