using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnPhuocShop.Models
{
    public class AnPhuoc
    {
        public int AnPhuocId { get; set; }
        public string Tensp { get; set; }
        public string Hoatiet { get; set; }
        public string Gia { get; set; }
        public string Thongtin { get; set; }
        public int LoaispId { get; set; }
        public string Hinhanh { get; set; }
    }
}
