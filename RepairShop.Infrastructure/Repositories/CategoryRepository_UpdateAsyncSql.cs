﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Infrastructure.Repositories
{
    public partial class CategoryRepository
    {
        public const string UpdateAsyncSql = @"UPDATE[dbo].[Categories]
                                                    SET [Name] = @Name
                                                  ,[Description] = @Description
                                             WHERE Id=@Id"; 
    }
}
