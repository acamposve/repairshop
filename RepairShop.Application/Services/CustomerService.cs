using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Services
{
    public class CustomerService : ICustomerService
    {

        private IUnitOfWork _uow;
        public CustomerService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _uow.Customers.GetAllAsync();
        }

        public async Task<int> AddAsync(Customer entity)
        {
            return await _uow.Customers.AddAsync(entity);
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            return await _uow.Customers.DeleteAsync(id);
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            return await _uow.Customers.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(Customer entity) {
            return await _uow.Customers.UpdateAsync(entity);
        }
    }
}
