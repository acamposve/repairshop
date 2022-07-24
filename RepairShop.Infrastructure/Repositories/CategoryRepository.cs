using Dapper;
using Microsoft.Extensions.Configuration;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> AddAsync(Category entity)
        {
            entity.AddedOn = DateTime.Now;
            using var connection = GetSqlConnection();
            return await connection.ExecuteAsync(AddSql, entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            using var connection = GetSqlConnection();
            var result = await connection.ExecuteAsync(DeleteAsyncSql, new { Id = id });
            return result;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            using var connection = GetSqlConnection();
            var result = await connection.QuerySingleOrDefaultAsync<Category>(GetByIdAsyncSql, new { Id = id });
            return result;
        }

        public async Task<int> UpdateAsync(Category entity)
        {
            entity.ModifiedOn = DateTime.Now;
            using var connection = GetSqlConnection();
            var result = await connection.ExecuteAsync(UpdateAsyncSql, entity);
            return result;
        }

        public async Task<IReadOnlyList<Category>> GetAllAsync()
        {
            using var connection = GetSqlConnection();
            var result = await connection.QueryAsync<Category>(GetAllSql);
            return result.ToList();
        }
    }
}
