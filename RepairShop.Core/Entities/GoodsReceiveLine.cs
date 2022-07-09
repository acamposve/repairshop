using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RepairShop.Core.Entities
{
    public class GoodsReceiveLine
    {
        public Guid GoodsReceiveLineId { get; set; }
        public Guid GoodsReceiveId { get; set; }
        [JsonIgnore]
        public GoodsReceive GoodsReceive { get; set; }
        public Guid PurchaseOrderLineId { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int QtyPurchase { get; set; }
        public int QtyReceive { get; set; }
        public int QtyReceived { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
