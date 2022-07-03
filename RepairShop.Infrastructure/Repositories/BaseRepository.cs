using Microsoft.Extensions.Configuration;
using RepairShop.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public class BaseRepository: IBaseRepository
    {
        private readonly IConfiguration configuration;

        public BaseRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public SqlConnection Connection() { 
        
            return new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        
    }
}
