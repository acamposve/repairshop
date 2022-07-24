using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Core.Entities
{
    public class InvenTran
    {
        public int InvenTranId { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TranSourceId { get; set; }
        public string TranSourceNumber { get; set; }
        public string TranSourceType { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset? InvenTranDate { get; set; } = DateTime.Now;
        public DateTime AddedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
