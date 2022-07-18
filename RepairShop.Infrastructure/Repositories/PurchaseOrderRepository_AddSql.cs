using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class PurchaseOrderRepository
    {
        public const string AddSql = @"INSERT INTO [PurchaseOrder]
                                           ([PurchaseOrderId]
                                           ,[Number]
                                           ,[Description]
                                           ,[PurchaseOrderDate]
                                           ,[VendorId])
                                     VALUES
                                           (@PurchaseOrderId
                                           ,@Number
                                           ,@Description
                                           ,@PurchaseOrderDate
                                           ,@VendorId)";
    }
}
