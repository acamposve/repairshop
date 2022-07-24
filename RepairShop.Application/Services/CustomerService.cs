using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;
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

        public async Task<int> AddAsync(CustomerRequest entity)
        {
            var customer = new Customer
            {
                Address = entity.Address,
                Address2 = entity.Address2,
                Description = entity.Description,
                Email = entity.Email,
                Name = entity.Name,
                Phone = entity.Phone,
                AddedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
            };

            return await _uow.Customers.AddAsync(customer);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _uow.Customers.DeleteAsync(id);
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _uow.Customers.GetByIdAsync(id);
        }
        public async Task<int> UpdateAsync(int id, Customer entity) {
            entity.CustomerId = id;
            return await _uow.Customers.UpdateAsync(entity);
        }
    }
}
