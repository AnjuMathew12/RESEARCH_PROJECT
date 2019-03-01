using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCDatabaseApp.Models
{
    public class CustomerContext:DbContext
    {
        public CustomerContext():base("mycon")
        {
            DropCreateDatabaseIfModelChanges<CustomerContext> d = new DropCreateDatabaseIfModelChanges<CustomerContext>();
            Database.SetInitializer<CustomerContext>(d);
        }
        public DbSet<Customer1> Customers { get; set; }
    }
}