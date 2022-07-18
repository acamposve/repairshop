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
    public partial class PurchaseOrderLineRepository : IPurchaseOrderLineRepository
    {
        private readonly IConfiguration configuration;


        public PurchaseOrderLineRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<int> AddAsync(PurchaseOrderLine entity)
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

        public async Task<IReadOnlyList<PurchaseOrderLine>> GetAllAsync()
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QueryAsync<PurchaseOrderLine>(GetAllSql);
            return result.ToList();
        }

        public async Task<PurchaseOrderLine> GetByIdAsync(Guid id)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.QuerySingleOrDefaultAsync<PurchaseOrderLine>(GetByIdAsyncSql, new { Id = id });
            return result;
        }

        public async Task<int> UpdateAsync(PurchaseOrderLine entity)
        {
            entity.ModifiedOn = DateTime.Now;
            using var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            connection.Open();
            var result = await connection.ExecuteAsync(UpdateAsyncSql, entity);
            return result;
        }
    }
}
