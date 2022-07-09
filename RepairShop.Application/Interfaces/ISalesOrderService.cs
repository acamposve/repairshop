using RepairShop.Core.Entities;

namespace RepairShop.Application.Interfaces
{
    public interface ISalesOrderService
    {
        Task<IEnumerable<SalesOrder>> GetAll();

        Task<int> AddAsync(SalesOrder entity);
        Task<int> DeleteAsync(Guid id);
        Task<SalesOrder> GetByIdAsync(Guid id);
        Task<int> UpdateAsync(SalesOrder entity);
    }
}
