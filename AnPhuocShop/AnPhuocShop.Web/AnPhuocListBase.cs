using Microsoft.AspNetCore.Components;
using AnPhuocShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Web
{
    public class AnPhuocListBase:ComponentBase
    {
        public IEnumerable<AnPhuoc> AnPhuocs { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadAnPhuocs();
            return base.OnInitializedAsync();
        }

        private void LoadAnPhuocs()
        {
            AnPhuoc a1 = new AnPhuoc
            {
                AnPhuocId = 1,
                Tensp = "Áo Sơ mi Nam ngắn tay An Phước - ASN002182",
                Hoatiet = "Trơn",
                Gia = "905.000 đ",
                //Loaisp = new Loaisp { LoaispId = 1, LoaispName = "Áo Sơ mi Nam" },
                LoaispId = 1,
                Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\n" +
                "Chính sách đổi hàng:\n" +
                "- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n" +
                "- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n" +
                "- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày.",
                Hinhanh = "image/ASN002182.jpg",
            };
            AnPhuoc a2 = new AnPhuoc
            {
                AnPhuocId = 2,
                Tensp = "Áo Thun Nam tay ngắn Pierre Cardin - PTH000268",
                Hoatiet = "Trơn",
                Gia = "1.418.000 đ",
                //Loaisp = new Loaisp { LoaispId = 2, LoaispName = "Áo Thun Nam" },
                LoaispId = 2,
                Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\n" +
               "Chính sách đổi hàng:\n" +
               "- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n" +
               "- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n" +
               "- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày.",
                Hinhanh = "image/PTH000268.jpg",
            };
            AnPhuoc a3 = new AnPhuoc
            {
                AnPhuocId = 3,
                Tensp = "Áo Sơ mi Nam ngắn tay An Phước - ASN002225",
                Hoatiet = "Bông",
                Gia = "668.000 đ",
                LoaispId = 3,
                Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\n" +
               "Chính sách đổi hàng:\n" +
               "- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n" +
               "- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n" +
               "- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày.",
                Hinhanh = "image/ASN002225.jpg",
            };
            AnPhuoc a4 = new AnPhuoc
            {
                AnPhuocId = 4,
                Tensp = "Áo Jacket Nữ An Phước - AJKN00103",
                Hoatiet = "Bông",
                Gia = "928.000 đ",
                //Loaisp = new Loaisp { LoaispId = 2, LoaispName = "Áo Jacket Nữ" },
                LoaispId = 4,
                Thongtin = "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\n" +
               "Chính sách đổi hàng:\n" +
               "- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n" +
               "- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n" +
               "- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày.",
                Hinhanh = "image/AJKN00103.jpg",
            };
            AnPhuocs = new List<AnPhuoc> { a1, a2, a3, a4 };
        }
    }
}
