using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class GoodsReceiveLineService : IGoodsReceiveLineService
    {
        private readonly IUnitOfWork _uow;
        public GoodsReceiveLineService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }


        public async Task<IEnumerable<GoodsReceiveLine>> GetAll()
        {
            return await _uow.GoodsReceiveLines.GetAllAsync();
        }

        public async Task<int> AddAsync(GoodsReceiveLine entity)
        {
            return await _uow.GoodsReceiveLines.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _uow.GoodsReceiveLines.DeleteAsync(id);
        }

        public async Task<GoodsReceiveLine> GetByIdAsync(int id)
        {
            return await _uow.GoodsReceiveLines.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(GoodsReceiveLine entity)
        {
            return await _uow.GoodsReceiveLines.UpdateAsync(entity);
        }
    }
}
