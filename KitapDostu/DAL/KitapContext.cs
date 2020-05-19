using KitapDostu.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KitapDostu.DAL
{

    public class KitapContext : DbContext
    {
        public KitapContext() : base("cstr")
        {

        }

        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Okuyan> Okuyanlar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Kitap>().ToTable("tblKitaplar");

            modelBuilder.Entity<Kitap>().Property(k => k.KitapAdi).HasMaxLength(50).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Kitap>().Property(k => k.Yazar).HasMaxLength(35).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Kitap>().Property(k => k.Sayfa).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Kitap>().Property(k => k.Kitapid).IsRequired().HasColumnType("int");

            modelBuilder.Entity<Okuyan>().ToTable("tblOkuyan");

            modelBuilder.Entity<Okuyan>().Property(o => o.OkuyanAd).HasMaxLength(25).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Okuyan>().Property(o => o.OkuyanSoyad).HasMaxLength(25).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Okuyan>().Property(o=>o.Okuyanid).IsRequired().HasColumnType("int");

            modelBuilder.Entity<Kullanici>().ToTable("tblKullanici");

            modelBuilder.Entity<Kullanici>().Property(o => o.Ad).HasMaxLength(25).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Kullanici>().Property(o => o.Sifre).HasMaxLength(25).IsRequired().HasColumnType("varchar");
        }
    }
}