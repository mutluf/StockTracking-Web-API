﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockTracking.Domain.Entities;
using StockTracking.Domain.Entities.User;

namespace StockTracking.Persistence.Context
{
    public class StockTrackingAPIDbContext : IdentityDbContext<User,Role,int>
    {
        public StockTrackingAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Depot> Depots { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<StockMovementType> StockMovementTypes { get; set;}
        
    }
}
