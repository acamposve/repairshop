using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Core.Entities
{
    public class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }
        [Required]
        public string Number { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? PurchaseOrderDate { get; set; } = DateTime.Now;
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public virtual List<PurchaseOrderLine> PurchaseOrderLine { get; set; } = new List<PurchaseOrderLine>();
        public DateTime AddedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
