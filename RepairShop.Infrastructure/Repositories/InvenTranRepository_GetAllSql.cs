using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class InvenTranRepository
    {
        public const string GetAllSql = @"SELECT[InvenTranId]
                                          ,[Number]
                                          ,[Description]
                                          ,[ProductId]
                                          ,[TranSourceId]
                                          ,[TranSourceNumber]
                                          ,[TranSourceType]
                                          ,[Quantity]
                                          ,[InvenTranDate]
                                            FROM [InvenTran]";

    }
}
