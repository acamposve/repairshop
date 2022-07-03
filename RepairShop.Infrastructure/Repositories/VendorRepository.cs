using Dapper;
using Microsoft.Extensions.Configuration;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System.Data.SqlClient;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class VendorRepository: IVendorRepository
    {
        private readonly IConfiguration configuration;
        

        public VendorRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<int> AddAsync(Vendor entity)
        {
            entity.AddedOn = DateTime.Now;
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.ExecuteAsync(AddSql, entity);
            return result;
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.ExecuteAsync(DeleteAsyncSql, new { Id = id });
            return result;
        }
        public async Task<IReadOnlyList<Vendor>> GetAllAsync()
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QueryAsync<Vendor>(GetAllSql);
            return result.ToList();
        }
        public async Task<Vendor> GetByIdAsync(Guid id)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QuerySingleOrDefaultAsync<Vendor>(GetByIdAsyncSql, new { Id = id });
            return result;
        }
        public async Task<int> UpdateAsync(Vendor entity)
        {
            entity.ModifiedOn = DateTime.Now;
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.ExecuteAsync(UpdateAsyncSql, entity);
            return result;
        }
    }
}
