using Dapper;
using Microsoft.Extensions.Configuration;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> AddAsync(Customer entity)
        {
            entity.AddedOn = DateTime.Now;
            using var connection = GetSqlConnection();
            return await connection.ExecuteAsync(AddSql, entity);
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            using var connection = GetSqlConnection();
            var result = await connection.ExecuteAsync(DeleteAsyncSql, new { Id = id });
            return result;
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            using var connection = GetSqlConnection();
            var result = await connection.QuerySingleOrDefaultAsync<Customer>(GetByIdAsyncSql, new { Id = id });
            return result;
        }

        public async Task<int> UpdateAsync(Customer entity)
        {
            entity.ModifiedOn = DateTime.Now;
            using var connection = GetSqlConnection();
            var result = await connection.ExecuteAsync(UpdateAsyncSql, entity);
            return result;
        }

        public async Task<IReadOnlyList<Customer>> GetAllAsync()
        {
            using var connection = GetSqlConnection();
            var result = await connection.QueryAsync<Customer>(GetAllSql);
            return result.ToList();
        }
    }
}
