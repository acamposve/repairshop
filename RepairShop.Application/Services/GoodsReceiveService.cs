using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class GoodsReceiveService : IGoodsReceiveService
    {
        private readonly IUnitOfWork _uow;
        public GoodsReceiveService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }


        public async Task<IEnumerable<GoodsReceive>> GetAll()
        {
            return await _uow.GoodsReceives.GetAllAsync();
        }

        public async Task<int> AddAsync(GoodsReceive entity)
        {
            return await _uow.GoodsReceives.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _uow.GoodsReceives.DeleteAsync(id);
        }

        public async Task<GoodsReceive> GetByIdAsync(int id)
        {
            return await _uow.GoodsReceives.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(GoodsReceive entity)
        {
            return await _uow.GoodsReceives.UpdateAsync(entity);
        }
    }
}
