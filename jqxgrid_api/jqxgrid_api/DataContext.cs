using jqxgrid_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace jqxgrid_api
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var emp = modelBuilder.Entity<Employee>();
            emp.HasKey(x => x.Id);
        }
    }
}