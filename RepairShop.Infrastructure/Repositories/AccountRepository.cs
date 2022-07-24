using Dapper;
using Microsoft.Extensions.Configuration;
using RepairShop.Application.Interfaces;
using RepairShop.Core.Entities;
using RepairShop.Core.Entities.Request;
using RepairShop.Core.Entities.Response;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class AccountRepository : BaseRepository, IAccountRepository
    {
        public AccountRepository(IConfiguration configuration) : base(configuration)  {}

        public Task<int> AddAsync(Account entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Account>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<AuthenticateResponse> GetByEmailAsync(AuthenticateRequest model, string ipAddress)
        {
            using var connection = GetSqlConnection();
            var result = await connection.QuerySingleOrDefaultAsync<AuthenticateResponse>(GetByEmailAsyncSql, new { Email = model.Email, Password = model.Password });
            return result;
        }

        public Task<Account> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
