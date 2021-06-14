﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace _19010230_e_commerce_store.Models
{
    public partial class prog7311Task2Context : DbContext
    {
        public prog7311Task2Context()
        {
        }

        public prog7311Task2Context(DbContextOptions<prog7311Task2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderInfo> OrderInfos { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Connection string moved to appsettings.json
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<OrderInfo>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__orderInf__0809337D176BD5C2");

                entity.ToTable("orderInfo");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderInfos)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orderInfo__produ__3A81B327");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OrderInfos)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__orderInfo__userI__3B75D760");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("productID");

                entity.Property(e => e.CategoryId).HasColumnName("categoryID");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("productDescription");

                entity.Property(e => e.ProductImage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("productImage");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("productPrice");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__product__categor__2B3F6F97");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__productC__23CAF1F8D0E2F80E");

                entity.ToTable("productCategory");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("categoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("categoryName");

                entity.Property(e => e.TotalOrders).HasColumnName("totalOrders");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__userInfo__CB9A1CDF1EB74E07");

                entity.ToTable("userInfo");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userEmail");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userPassword");

                entity.Property(e => e.UserType).HasColumnName("userType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
