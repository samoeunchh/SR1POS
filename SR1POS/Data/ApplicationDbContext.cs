using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SR1POS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SR1POS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductPrice> ProductPrice { get; set; }
    }
}
