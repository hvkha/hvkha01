using AnPhuocShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Api.Models
{
    public interface ILoaispRepository
    {
        IEnumerable<Loaisp> GetLoaisps();
        Loaisp GetLoaisp(int loaispId);
        Loaisp AddLoaisp(Loaisp loaisp);
        Loaisp UpdateLoaisp(Loaisp loaisp);
        void DeleteLoaisp(int loaispId);
    }
}
