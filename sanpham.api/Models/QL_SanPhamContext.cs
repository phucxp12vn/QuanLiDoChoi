using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace sanpham.api.Models
{
    public partial class QL_SanPhamContext : DbContext
    {
        public QL_SanPhamContext()
        {
        }

        public QL_SanPhamContext(DbContextOptions<QL_SanPhamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sanpham> Sanpham { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=172.18.33.187,1433;Database=QL_SanPham;User ID=sa;Password=Password1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("SANPHAM");

                entity.Property(e => e.MaSp)
                    .HasColumnName("MaSP")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.GiaBanLe).HasColumnType("decimal(19, 3)");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hinhanhindex)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MotaSp)
                    .HasColumnName("MotaSP")
                    .HasMaxLength(200);

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasColumnName("TenSP")
                    .HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasMaxLength(20);

                entity.Property(e => e.XuatSu).HasMaxLength(20);
            });
        }
    }
}
