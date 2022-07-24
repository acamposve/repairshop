using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Core.Entities
{
    public class SalesOrder
    {
        public int SalesOrderId { get; set; }
        [Required]
        public string Number { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? SalesOrderDate { get; set; } = DateTime.Now;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public virtual List<SalesOrderLine> SalesOrderLine { get; set; } = new List<SalesOrderLine>();

        public DateTime AddedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
