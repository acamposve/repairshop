using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Core.Entities.Request
{
    public class PurchaseOrderRequest
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public Guid VendorId { get; set; }
    }
}
