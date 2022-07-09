using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class PurchaseOrderRepository
    {
        public const string UpdateAsyncSql = @"UPDATE [dbo].[PurchaseOrder]
                                               SET [Number] = @Number
                                                  ,[Description] = @Description
                                                  ,[PurchaseOrderDate] = @PurchaseOrderDate
                                                  ,[VendorId] = @VendorId
                                             WHERE [PurchaseOrderId] = @Id";
    }
}
