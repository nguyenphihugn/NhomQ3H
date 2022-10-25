using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CuaHangTRex.DataTier.Models
{
    public partial class QuanLyShopGiayModels : DbContext
    {
        public QuanLyShopGiayModels()
            : base("name=QuanLyShopGiayModels3")
        {
        }

        public virtual DbSet<Chung_Loai> Chung_Loai { get; set; }
        public virtual DbSet<CT_HD> CT_HD { get; set; }
        public virtual DbSet<CT_NhapHang> CT_NhapHang { get; set; }
        public virtual DbSet<Hoa_Don> Hoa_Don { get; set; }
        public virtual DbSet<Khach_Hang> Khach_Hang { get; set; }
        public virtual DbSet<Nhan_Vien> Nhan_Vien { get; set; }
        public virtual DbSet<Noi_Cung_Cap> Noi_Cung_Cap { get; set; }
        public virtual DbSet<Phieu_Nhap_Hang> Phieu_Nhap_Hang { get; set; }
        public virtual DbSet<San_Pham> San_Pham { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chung_Loai>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Chung_Loai>()
                .HasMany(e => e.San_Pham)
                .WithRequired(e => e.Chung_Loai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_HD>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HD>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_NhapHang>()
                .Property(e => e.MaPhieuNhapHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_NhapHang>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoa_Don>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoa_Don>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoa_Don>()
                .Property(e => e.MaNVLap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khach_Hang>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Khach_Hang>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_Vien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_Vien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_Vien>()
                .Property(e => e.TenTK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_Vien>()
                .Property(e => e.MK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_Vien>()
                .HasMany(e => e.Hoa_Don)
                .WithRequired(e => e.Nhan_Vien)
                .HasForeignKey(e => e.MaNVLap);

            modelBuilder.Entity<Nhan_Vien>()
                .HasMany(e => e.Phieu_Nhap_Hang)
                .WithRequired(e => e.Nhan_Vien)
                .HasForeignKey(e => e.MaNVLap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Noi_Cung_Cap>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Noi_Cung_Cap>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Noi_Cung_Cap>()
                .HasMany(e => e.San_Pham)
                .WithRequired(e => e.Noi_Cung_Cap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phieu_Nhap_Hang>()
                .Property(e => e.MaPhieuNhapHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phieu_Nhap_Hang>()
                .Property(e => e.MaNVLap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<San_Pham>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<San_Pham>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<San_Pham>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<San_Pham>()
                .HasMany(e => e.CT_NhapHang)
                .WithRequired(e => e.San_Pham)
                .WillCascadeOnDelete(false);
        }
    }
}
