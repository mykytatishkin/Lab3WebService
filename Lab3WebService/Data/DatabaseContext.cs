using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Lab3WebService.Models;

using System.Collections.Generic;

namespace Lab3WebService.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; } = default!;
        public DbSet<Accounts> Accounts { get; set; } = default!;
        public DbSet<Products> Products { get; set; } = default!;
        public DbSet<Shops> Shops { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<Accounts>().HasIndex(a => a.UserId).IsUnique();
            modelBuilder.Entity<Shops>().HasIndex(s => s.Name).IsUnique();
            modelBuilder.Entity<Products>().HasIndex(p => p.OwnerId).IsUnique();
        }
    }
}
