using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Core.Entities.Request
{
    public class ProductRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
       
        public decimal PriceSell { get; set; }
        public decimal PricePurchase { get; set; }
    }
}
