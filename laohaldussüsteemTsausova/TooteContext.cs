using laohaldussüsteemTsausova.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace laohaldussüsteemTsausova
{
    public class TooteContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}