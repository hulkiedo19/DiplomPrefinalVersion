using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfApp3.Models;

public partial class Test1Context : DbContext
{
    public Test1Context()
    {
    }

    public Test1Context(DbContextOptions<Test1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Kit> Kits { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<Stockroom> Stockrooms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-F43SE643F8E; Database=Test1; TrustServerCertificate=Yes; Integrated Security=SSPI; Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kit__3214EC075C0B0757");

            entity.ToTable("Kit");

            entity.HasOne(d => d.ProductType).WithMany(p => p.Kits)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK__Kit__ProductType__4D94879B");

            entity.HasOne(d => d.Stockroom).WithMany(p => p.Kits)
                .HasForeignKey(d => d.StockroomId)
                .HasConstraintName("FK__Kit__StockroomId__4E88ABD4");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Order__3214EC0723B891C0");

            entity.ToTable("Order");

            entity.Property(e => e.DepartureDate).HasColumnType("date");
            entity.Property(e => e.StartPreparationDate).HasColumnType("date");

            entity.HasOne(d => d.Kit).WithMany(p => p.Orders)
                .HasForeignKey(d => d.KitId)
                .HasConstraintName("FK__Order__KitId__5165187F");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductT__3214EC07BEBC39DC");

            entity.ToTable("ProductType");
        });

        modelBuilder.Entity<Stockroom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stockroo__3214EC077E19DC5F");

            entity.ToTable("Stockroom");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
