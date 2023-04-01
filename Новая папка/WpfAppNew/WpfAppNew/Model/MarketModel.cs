﻿using System;
using System.Data.Entity;
using System.Linq;

namespace WpfAppNew.Model
{
    
    public class MarketModel : DbContext
    {
        static MarketModel()
        {
            
        }
        
        public MarketModel()
            : base("name=MarketModel")
        {     
        }
        
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SelleCategory> Categories { get; set; }
        public virtual DbSet<Cash> Cashes { get; set; }
        public virtual DbSet<SalesContnt> Contnts { get; set; }

        

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}