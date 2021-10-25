using AnPhuocShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Api
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }

        public DbSet<AnPhuoc> AnPhuocs { get; set; }
        public DbSet<Loaisp> Loaisps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Loaisp>().HasData(
                new Loaisp { LoaispId = 1, LoaispName = "Áo Sơ mi Nam" });
            modelBuilder.Entity<Loaisp>().HasData(
                new Loaisp { LoaispId = 2, LoaispName = "Áo Thun Nam" });
            modelBuilder.Entity<Loaisp>().HasData(
                new Loaisp { LoaispId = 3, LoaispName = "Áo Sơ mi Nam" });
            modelBuilder.Entity<Loaisp>().HasData(
                new Loaisp { LoaispId = 4, LoaispName = "Áo Jacket Nữ" });

            // Seed Employee Table
            modelBuilder.Entity<AnPhuoc>().HasData(new AnPhuoc
            {
                AnPhuocId = 1,
                Tensp = "Áo Sơ mi Nam ngắn tay An Phước - ASN002182",
                Hoatiet = "Trơn",
                Gia = "905.000 đ",
                //Loaisp = new Loaisp { LoaispId = 1, LoaispName = "Áo Sơ mi Nam" },
                Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\n" +
                "Chính sách đổi hàng:\n" +
                "- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n" +
                "- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n" +
                "- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày.",
                LoaispId = 1,
                Hinhanh = "image/ASN002182.jpg"
            });

            modelBuilder.Entity<AnPhuoc>().HasData(new AnPhuoc
            {
                AnPhuocId = 2,
                Tensp = "Áo Thun Nam tay ngắn Pierre Cardin - PTH000268",
                Hoatiet = "Trơn",
                Gia = "1.418.000 đ",
                //Loaisp = new Loaisp { LoaispId = 2, LoaispName = "Áo Thun Nam" },
                Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\n" +
               "Chính sách đổi hàng:\n" +
               "- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n" +
               "- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n" +
               "- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày.",
                LoaispId = 2,
                Hinhanh = "image/PTH000268.jpg"
            });

            modelBuilder.Entity<AnPhuoc>().HasData(new AnPhuoc
            {
                AnPhuocId = 3,
                Tensp = "Áo Sơ mi Nam ngắn tay An Phước - ASN002225",
                Hoatiet = "Bông",
                Gia = "668.000 đ",
                Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\n" +
               "Chính sách đổi hàng:\n" +
               "- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n" +
               "- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n" +
               "- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày.",
                LoaispId = 3,
                Hinhanh = "image/ASN002225.jpg"
            });

            modelBuilder.Entity<AnPhuoc>().HasData(new AnPhuoc
            {
                AnPhuocId = 4,
                Tensp = "Áo Jacket Nữ An Phước - AJKN00103",
                Hoatiet = "Bông",
                Gia = "928.000 đ",
                //Loaisp = new Loaisp { LoaispId = 2, LoaispName = "Áo Jacket Nữ" },
                Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\n" +
               "Chính sách đổi hàng:\n" +
               "- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n" +
               "- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n" +
               "- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày.",
                LoaispId = 4,
                Hinhanh = "image/AJKN00103.jpg"
            });
        }
    }
}
