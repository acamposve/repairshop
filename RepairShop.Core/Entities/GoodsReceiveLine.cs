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
        public int GoodsReceiveLineId { get; set; }
        public int GoodsReceiveId { get; set; }
        [JsonIgnore]
        public GoodsReceive GoodsReceive { get; set; }
        public int PurchaseOrderLineId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int QtyPurchase { get; set; }
        public int QtyReceive { get; set; }
        public int QtyReceived { get; set; }
        public DateTime AddedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
