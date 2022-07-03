using Dapper;
using Microsoft.Extensions.Configuration;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System.Data.SqlClient;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class CustomerRepository : ICustomerRepository
    {
        private readonly IConfiguration configuration;


        public CustomerRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<int> AddAsync(Customer entity)
        {
            entity.AddedOn = DateTime.Now;
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            return await connection.ExecuteAsync(AddSql, entity);
        }
        public async Task<int> DeleteAsync(Guid id)
        {

            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.ExecuteAsync(DeleteAsyncSql, new { Id = id });
            return result;
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QuerySingleOrDefaultAsync<Customer>(GetByIdAsyncSql, new { Id = id });
            return result;
        }
        public async Task<int> UpdateAsync(Customer entity)
        {
            entity.ModifiedOn = DateTime.Now;
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(UpdateAsyncSql, entity);
                return result;
            }
        }

        public async Task<IReadOnlyList<Customer>> GetAllAsync()
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QueryAsync<Customer>(GetAllSql);
            return result.ToList();
        }
    }
}
