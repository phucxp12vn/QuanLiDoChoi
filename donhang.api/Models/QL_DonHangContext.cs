using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace donhang.api.Models
{
    public partial class QL_DonHangContext : DbContext
    {
        public QL_DonHangContext()
        {
        }

        public QL_DonHangContext(DbContextOptions<QL_DonHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitietdonhang> Chitietdonhang { get; set; }
        public virtual DbSet<Donhang> Donhang { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=172.18.36.51;Database=QL_DonHang;User ID=sa;Password=Password1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chitietdonhang>(entity =>
            {
                entity.HasKey(e => new { e.MaDh, e.MaSp });

                entity.ToTable("CHITIETDONHANG");

                entity.Property(e => e.MaDh)
                    .HasColumnName("MaDH")
                    .HasMaxLength(50);

                entity.Property(e => e.MaSp)
                    .HasColumnName("MaSP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(19, 3)");
            });

            modelBuilder.Entity<Donhang>(entity =>
            {
                entity.HasKey(e => e.MaDh);

                entity.ToTable("DONHANG");

                entity.Property(e => e.MaDh)
                    .HasColumnName("MaDH")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.ShipAddress).HasMaxLength(50);

                entity.Property(e => e.ShipMobile).HasMaxLength(50);

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TongTien).HasColumnType("decimal(19, 3)");
            });
        }
    }
}
