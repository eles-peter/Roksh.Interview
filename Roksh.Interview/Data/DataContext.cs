using Microsoft.EntityFrameworkCore;
using Roksh.Interview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roksh.Interview.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<PackState> PackStates { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PackProduct> PackProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PackProduct>()
                .HasKey(pp => new { pp.PackId, pp.ProductId });
        }

    }
}
