using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class PurchaseOrderLineRepository
    {
        public const string GetAllSql = @"SELECT [PurchaseOrderId]
                                              ,[Number]
                                              ,[Description]
                                              ,[PurchaseOrderDate]
                                              ,[VendorId]
                                          FROM [dbo].[PurchaseOrder]
                                        WHERE  [PurchaseOrderId] = @Id";
    }
}
