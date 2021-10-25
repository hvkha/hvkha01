using AnPhuocShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Api.Models
{
    public class LoaispRepository : ILoaispRepository
    {
        private readonly AppDbContext appDbContext;
        public LoaispRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public Loaisp AddLoaisp(Loaisp loaisp)
        {
            var result = appDbContext.Loaisps.Add(loaisp);
            appDbContext.SaveChanges();
            return result.Entity;
        }

        public void DeleteLoaisp(int loaispId)
        {
            var result = appDbContext.Loaisps
                .FirstOrDefault(l => l.LoaispId == loaispId);
            if (result != null)
            {
                appDbContext.Loaisps.Remove(result);
                appDbContext.SaveChanges();
            }
        }

        public Loaisp GetLoaisp(int loaispId)
        {
            return appDbContext.Loaisps.FirstOrDefault(l => l.LoaispId == loaispId);
        }

        public IEnumerable<Loaisp> GetLoaisps()
        {
            return appDbContext.Loaisps;
        }

        public Loaisp UpdateLoaisp(Loaisp loaisp)
        {
            var result = appDbContext.Loaisps
                 .FirstOrDefault(l => l.LoaispId == loaisp.LoaispId);
            if (result != null)
            {
                result.LoaispName = loaisp.LoaispName;
                appDbContext.SaveChanges();
                return result;
            }
            return null;
        }
    }
}
