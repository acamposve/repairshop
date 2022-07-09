﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class PurchaseOrderLineRepository
    {
        public const string GetAllSql = @"SELECT [PurchaseOrderLineId]
                                              ,[PurchaseOrderId]
                                              ,[ProductId]
                                              ,[Quantity]
                                              ,[Price]
                                              ,[SubTotal]
                                              ,[Discount]
                                              ,[Total]
                                          FROM [PurchaseOrderLine]";
    }
}
