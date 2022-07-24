using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class VendorService : IVendorService
    {
        private IUnitOfWork _uow;
        public VendorService(IUnitOfWork unitOfWork)
        {
            _uow=unitOfWork;
        }

        public async Task<IEnumerable<Vendor>> GetAll()
        {
            return await _uow.Vendors.GetAllAsync();
        }

        public async Task<int> AddAsync(Vendor entity)
        {
            return await _uow.Vendors.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _uow.Vendors.DeleteAsync(id);
        }

        public async Task<Vendor> GetByIdAsync(int id)
        {
            return await _uow.Vendors.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(int id, Vendor entity)
        {
            entity.VendorId = id;
            return await _uow.Vendors.UpdateAsync(entity);
        }
    }
}
