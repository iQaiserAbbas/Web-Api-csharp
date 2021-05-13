using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Assignment1.Models
{
    public class SQLDatabaseContext : DbContext
    {
        public SQLDatabaseContext() : base("name=SqlDatabaseConn")  
        {
        }
        public DbSet<Order> Orders { get; set; }
    }
}