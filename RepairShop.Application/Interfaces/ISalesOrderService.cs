using RepairShop.Core.Entities;

namespace RepairShop.Application.Interfaces
{
    public interface ISalesOrderService
    {
        Task<IEnumerable<SalesOrder>> GetAll();

        Task<int> AddAsync(SalesOrder entity);
        Task<int> DeleteAsync(int id);
        Task<SalesOrder> GetByIdAsync(int id);
        Task<int> UpdateAsync(SalesOrder entity);
    }
}
