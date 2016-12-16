﻿
using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Product> Products
        { get; set; }
    }
}