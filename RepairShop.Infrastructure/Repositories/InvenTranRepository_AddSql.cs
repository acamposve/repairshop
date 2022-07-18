using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class InvenTranRepository
    {
        public const string AddSql = @"INSERT INTO [InvenTran]
                                           ([InvenTranId]
                                           ,[Number]
                                           ,[Description]
                                           ,[ProductId]
                                           ,[TranSourceId]
                                           ,[TranSourceNumber]
                                           ,[TranSourceType]
                                           ,[Quantity]
                                           ,[InvenTranDate])
                                     VALUES
                                           (@InvenTranId
                                           ,@Number
                                           ,@Description
                                           ,@ProductId
                                           ,@TranSourceId
                                           ,@TranSourceNumber
                                           ,@TranSourceType
                                           ,@Quantity
                                           ,@InvenTranDate)";
    }
}
