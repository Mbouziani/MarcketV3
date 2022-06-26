using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MarcketV3.Models
{
    public partial class MarketManagementDBContext : DbContext
    {
        public MarketManagementDBContext()
        {
        }

        public MarketManagementDBContext(DbContextOptions<MarketManagementDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agents { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Reciep> Recieps { get; set; } = null!;
        public virtual DbSet<Reciepreturned> Reciepreturneds { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SaleZone> SaleZones { get; set; } = null!;
        public virtual DbSet<Salereturned> Salereturneds { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("Agent");

                entity.Property(e => e.AgentId).HasColumnName("agentId");

                entity.Property(e => e.AgentAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("agentAddress");

                entity.Property(e => e.AgentEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("agentEmail");

                entity.Property(e => e.AgentMobile)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("agentMobile");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("agentName");

                entity.Property(e => e.AgentTele)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("agentTele");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("branch");

                entity.Property(e => e.BranchId).HasColumnName("branchID");

                entity.Property(e => e.BranchAddress)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("branchAddress");

                entity.Property(e => e.BranchDirector)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("branchDirector");

                entity.Property(e => e.BranchMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("branchMobile");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("branchName");

                entity.Property(e => e.BranchNumber).HasColumnName("branchNumber");

                entity.Property(e => e.BranchPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("branchPhone");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.CompanyId).HasColumnName("companyID");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(550)
                    .IsUnicode(false)
                    .HasColumnName("companyAddress");

                entity.Property(e => e.CompanyCommercial)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("companyCommercial");

                entity.Property(e => e.CompanyMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("companyMobile");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("companyName");

                entity.Property(e => e.CompanyNumber).HasColumnName("companyNumber");

                entity.Property(e => e.CompanyPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("companyPhone");

                entity.Property(e => e.CompanyTaxNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("companyTaxNumber");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.ProductActiveStatus).HasColumnName("productActiveStatus");

                entity.Property(e => e.ProductBarcode)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("productBarcode");

                entity.Property(e => e.ProductImageLink)
                    .HasMaxLength(700)
                    .IsUnicode(false)
                    .HasColumnName("productImageLink");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.ProductPrice).HasColumnName("productPrice");

                entity.Property(e => e.ProductTypeSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productTypeSize");
            });

            modelBuilder.Entity<Reciep>(entity =>
            {
                entity.ToTable("reciep");

                entity.Property(e => e.ReciepId).HasColumnName("reciepID");

                entity.Property(e => e.PriceTotalWithTax).HasColumnName("priceTotalWithTax");

                entity.Property(e => e.ReciepDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("reciepDate");

                entity.Property(e => e.ReciepNumber).HasColumnName("reciepNumber");

                entity.Property(e => e.ReciepPaymentMethode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("reciepPaymentMethode");

                entity.Property(e => e.ReciepPaymentPrice).HasColumnName("reciepPaymentPrice");

                entity.Property(e => e.ReciepProductCount).HasColumnName("reciepProductCount");

                entity.Property(e => e.ReciepTotalPrice).HasColumnName("reciepTotalPrice");

                entity.Property(e => e.RecieppriceTax).HasColumnName("recieppriceTax");
            });

            modelBuilder.Entity<Reciepreturned>(entity =>
            {
                entity.HasKey(e => e.ReciepId)
                    .HasName("PK__reciepre__D5B2B8F1FFB68DD7");

                entity.ToTable("reciepreturned");

                entity.Property(e => e.ReciepId).HasColumnName("reciepID");

                entity.Property(e => e.PriceTotalWithTax).HasColumnName("priceTotalWithTax");

                entity.Property(e => e.ReciepDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("reciepDate");

                entity.Property(e => e.ReciepNumber).HasColumnName("reciepNumber");

                entity.Property(e => e.ReciepProductCount).HasColumnName("reciepProductCount");

                entity.Property(e => e.ReciepTotalPrice).HasColumnName("reciepTotalPrice");

                entity.Property(e => e.Reciepdescriptio)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("reciepdescriptio");

                entity.Property(e => e.RecieppriceTax).HasColumnName("recieppriceTax");

                entity.Property(e => e.ReturnedDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("returnedDate");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("sale");

                entity.Property(e => e.SaleId).HasColumnName("saleID");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.ProductTypeSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productTypeSize");

                entity.Property(e => e.ReciepId).HasColumnName("reciepID");

                entity.Property(e => e.ReciepNumber).HasColumnName("reciepNumber");

                entity.Property(e => e.SaleQuntity).HasColumnName("saleQuntity");

                entity.Property(e => e.SaleTotalPrice).HasColumnName("saleTotalPrice");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__sale__productID__2C3393D0");

                entity.HasOne(d => d.Reciep)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.ReciepId)
                    .HasConstraintName("FK__sale__reciepID__2D27B809");
            });

            modelBuilder.Entity<SaleZone>(entity =>
            {
                entity.ToTable("SaleZone");

                entity.Property(e => e.SaleZoneId).HasColumnName("SaleZoneID");

                entity.Property(e => e.SaleZoneAddress)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.SaleZoneDirector)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleZoneName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SaleZonePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Salereturned>(entity =>
            {
                entity.HasKey(e => e.SaleId)
                    .HasName("PK__saleretu__FAE8F5159BCF0BC6");

                entity.ToTable("salereturned");

                entity.Property(e => e.SaleId).HasColumnName("saleID");

                entity.Property(e => e.ProductId).HasColumnName("productID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.ProductTypeSize)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("productTypeSize");

                entity.Property(e => e.ReciepId).HasColumnName("reciepID");

                entity.Property(e => e.ReciepNumber).HasColumnName("reciepNumber");

                entity.Property(e => e.SaleQuntity).HasColumnName("saleQuntity");

                entity.Property(e => e.SaleTotalPrice).HasColumnName("saleTotalPrice");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Salereturneds)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__saleretur__produ__3B75D760");

                entity.HasOne(d => d.Reciep)
                    .WithMany(p => p.Salereturneds)
                    .HasForeignKey(d => d.ReciepId)
                    .HasConstraintName("FK__saleretur__recie__3C69FB99");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserAge)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("userAge");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("userEmail");

                entity.Property(e => e.UserName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.UserNumberLogin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userNumberLogin");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("userPassword");

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("userPhone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
