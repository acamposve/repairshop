using Dapper;
using Microsoft.Extensions.Configuration;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class ProductRepository : IProductRepository
    {
        private readonly IConfiguration configuration;


        public ProductRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<int> AddAsync(Product entity)
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

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QueryAsync<Product>(GetAllSql);
            return result.ToList();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QuerySingleOrDefaultAsync<Product>(GetByIdAsyncSql, new { Id = id });
            return result;
        }

        public async Task<int> UpdateAsync(Product entity)
        {
            entity.ModifiedOn = DateTime.Now;
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.ExecuteAsync(UpdateAsyncSql, entity);
            return result;
        }
    }
}
