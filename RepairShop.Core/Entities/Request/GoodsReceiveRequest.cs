using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Core.Entities.Request
{
    public class GoodsReceiveRequest
    {
        public string Description { get; set; }
        public Guid PurchaseOrderId { get; set; }
    }
}
