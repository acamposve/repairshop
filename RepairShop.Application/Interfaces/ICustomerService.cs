using RepairShop.Core.Entities;
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
        Task<int> AddAsync(Customer entity);
        Task<int> DeleteAsync(Guid id);
        Task<Customer> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(Customer entity);
    }
}
