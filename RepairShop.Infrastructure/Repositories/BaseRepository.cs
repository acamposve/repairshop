using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RepairShop.Infrastructure.Repositories
{
    public abstract class BaseRepository
    {
        private readonly IConfiguration configuration;

        protected BaseRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected IDbConnection GetSqlConnection()
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            return new SqlConnection(connectionString);
        }
    }
}
