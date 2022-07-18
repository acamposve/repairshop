using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class InvenTranService : IInvenTranService
    {
        private readonly IUnitOfWork _uow;
        public InvenTranService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }


        public async Task<IEnumerable<InvenTran>> GetAll()
        {
            return await _uow.InvenTrans.GetAllAsync();
        }

        public async Task<int> AddAsync(InvenTran entity)
        {
            return await _uow.InvenTrans.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await _uow.InvenTrans.DeleteAsync(id);
        }

        public async Task<InvenTran> GetByIdAsync(Guid id)
        {
            return await _uow.InvenTrans.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(InvenTran entity)
        {
            return await _uow.InvenTrans.UpdateAsync(entity);
        }
    }
}
