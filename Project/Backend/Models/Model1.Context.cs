﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PixelSpot1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PixelSpotEntities : DbContext
    {
        public PixelSpotEntities()
            : base("name=PixelSpotEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Collection_category> Collection_category { get; set; }
        public virtual DbSet<Downlaod> Downlaods { get; set; }
        public virtual DbSet<Liked_photos> Liked_photos { get; set; }
        public virtual DbSet<Photo_category> Photo_category { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Spam_photos> Spam_photos { get; set; }
        public virtual DbSet<User_collection> User_collection { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
