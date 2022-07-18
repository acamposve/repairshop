using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<int> AddAsync(CustomerRequest entity);
        Task<int> DeleteAsync(Guid id);
        Task<Customer> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(Guid id, Customer entity);
    }
}
