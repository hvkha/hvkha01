using AnPhuocShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Api.Models
{
    public interface IAnPhuocRepository
    {
        Task<IEnumerable<AnPhuoc>> GetAnPhuocs();

        Task<AnPhuoc> GetAnPhuoc(int anphuocId);
        Task<AnPhuoc> AddAnPhuoc(AnPhuoc anphuoc);
        Task<AnPhuoc> UpdateAnPhuoc(AnPhuoc anphuoc);
        Task<AnPhuoc> DeleteAnPhuoc(int anphuocId);
        Task<IEnumerable<AnPhuoc>> Search(string name);
    }
}
