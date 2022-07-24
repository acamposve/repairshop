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
    public partial class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly IConfiguration configuration;


        public PurchaseOrderRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<int> AddAsync(PurchaseOrder entity)
        {
            entity.AddedOn = DateTime.Now;
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            return await connection.QuerySingleAsync<int>(AddSql, entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.ExecuteAsync(DeleteAsyncSql, new { Id = id });
            return result;
        }

        public async Task<IReadOnlyList<PurchaseOrder>> GetAllAsync()
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QueryAsync<PurchaseOrder>(GetAllSql);
            return result.ToList();
        }

        public async Task<PurchaseOrder> GetByIdAsync(int id)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QuerySingleOrDefaultAsync<PurchaseOrder>(GetByIdAsyncSql, new { Id = id });
            return result;
        }

        public async Task<int> UpdateAsync(PurchaseOrder entity)
        {
            entity.ModifiedOn = DateTime.Now;
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.ExecuteAsync(UpdateAsyncSql, entity);
            return result;
        }
    }
}
