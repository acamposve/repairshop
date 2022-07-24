using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Core.Entities.Request
{
    public class PurchaseOrderRequest
    {
        public string Description { get; set; }
        public int VendorId { get; set; }
        public List<int> ProductId { get; set; }
    }
}
