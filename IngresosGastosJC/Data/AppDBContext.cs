using IngresosGastosJC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IngresosGastosJC.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("DefaultConnection")
        {

        }

        public DbSet<IngresosGastosJCL> IngresosGastos { get; set; }
    }
}