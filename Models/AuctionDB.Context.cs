﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuctionWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AuctionSiteDBEntities : DbContext
    {
        public AuctionSiteDBEntities()
            : base("name=AuctionSiteDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BannedUser> BannedUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Evalution> Evalutions { get; set; }
        public virtual DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public virtual DbSet<HistoryPrice> HistoryPrices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductsInCharge> ProductsInCharges { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WonProduct> WonProducts { get; set; }
    }
}