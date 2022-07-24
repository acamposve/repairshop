using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.Application.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenerateIdService _idService;
        public PurchaseOrderService(IUnitOfWork unitOfWork, IGenerateIdService idService)
        {
            _uow = unitOfWork;
            _idService = idService;
        }


        public async Task<IEnumerable<PurchaseOrder>> GetAll()
        {
            return await _uow.PurchaseOrders.GetAllAsync();
        }

        public async Task<int> AddAsync(PurchaseOrder entity)
        {
            entity.AddedOn = DateTime.Now;
            entity.ModifiedOn = DateTime.Now;
            entity.Number = _idService.GeneratePONumber();
            entity.PurchaseOrderDate = DateTime.Now;
            return await _uow.PurchaseOrders.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _uow.PurchaseOrders.DeleteAsync(id);
        }

        public async Task<PurchaseOrder> GetByIdAsync(int id)
        {
            return await _uow.PurchaseOrders.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(PurchaseOrder entity)
        {
            return await _uow.PurchaseOrders.UpdateAsync(entity);
        }
    }
}
