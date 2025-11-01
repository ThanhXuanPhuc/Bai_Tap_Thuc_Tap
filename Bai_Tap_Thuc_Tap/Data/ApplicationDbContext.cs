using Bai_Tap_Thuc_Tap.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_Tap_Thuc_Tap.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DonViTinh> DonViTinhs { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<Kho> Khos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<KhoUser> KhoUsers { get; set; }
        public DbSet<NhapKho> NhapKhos { get; set; }
        public DbSet<NhapKhoRawData> NhapKhoRawDatas { get; set; }
        public DbSet<XuatKho> XuatKhos { get; set; }
        public DbSet<XuatKhoRawData> XuatKhoRawDatas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Định nghĩa cặp khóa chính cho bảng KhoUser
            modelBuilder.Entity<KhoUser>()
                .HasKey(ku => new { ku.MaDangNhap, ku.KhoId });

            // Cấu hình mối quan hệ (tùy chọn nhưng nên có)
            modelBuilder.Entity<KhoUser>()
                .HasOne(ku => ku.User)
                .WithMany()
                .HasForeignKey(ku => ku.MaDangNhap)
                .HasPrincipalKey(u => u.MaDangNhap); // Quan trọng: Nối qua MaDangNhap thay vì Id

            modelBuilder.Entity<KhoUser>()
                .HasOne(ku => ku.Kho)
                .WithMany()
                .HasForeignKey(ku => ku.KhoId);
        }
    }
}
