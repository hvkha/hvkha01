using AnPhuocShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Web.Services
{
    public interface IAnPhuocService
    {
        Task<IEnumerable<AnPhuoc>> GetAnPhuocs();
        Task<AnPhuoc> GetAnPhuoc(int id);
    }
}
