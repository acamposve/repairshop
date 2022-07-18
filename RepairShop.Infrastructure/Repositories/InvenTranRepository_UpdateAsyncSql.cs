using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class InvenTranRepository
    {
        public const string UpdateAsyncSql = @"UPDATE [dbo].[InvenTran]
                                               SET [Number] = @Number
                                                  ,[Description] = @Description
                                                  ,[ProductId] = @ProductId
                                                  ,[TranSourceId] = @TranSourceId
                                                  ,[TranSourceNumber] = @TranSourceNumber
                                                  ,[TranSourceType] = @TranSourceType
                                                  ,[Quantity] = @Quantity
                                                  ,[InvenTranDate] = @InvenTranDate
                                             WHERE [InvenTranId] = @Id";
    }
}
