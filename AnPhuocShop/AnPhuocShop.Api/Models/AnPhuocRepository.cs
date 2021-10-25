using AnPhuocShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Api.Models
{
    public class AnPhuocRepository: IAnPhuocRepository
    {
        private readonly AppDbContext appDbContext;
        public AnPhuocRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext; 
        }

        public async Task<IEnumerable<AnPhuoc>> Search(string name)
        {
            IQueryable<AnPhuoc> query = appDbContext.AnPhuocs;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(a => a.Tensp.Contains(name));
            }
            return await query.ToListAsync();
        }
        public async Task<IEnumerable<AnPhuoc>> GetAnPhuocs()
        {
            return await appDbContext.AnPhuocs.ToListAsync();
        }
        public async Task<AnPhuoc> GetAnPhuoc(int anphuocId)
        {
            return await appDbContext.AnPhuocs.FirstOrDefaultAsync(a => a.AnPhuocId == anphuocId);
        }
        public async Task<AnPhuoc> AddAnPhuoc(AnPhuoc anphuoc)
        {
            var result = await appDbContext.AnPhuocs.AddAsync(anphuoc);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<AnPhuoc> UpdateAnPhuoc(AnPhuoc anphuoc)//cập nhật hoặc sữa nhân viên
        {
            var result = await appDbContext.AnPhuocs
                .FirstOrDefaultAsync(a => a.AnPhuocId == anphuoc.AnPhuocId);//Hàm tìm kiếm nhân viên
            if (result != null)
            {
                result.Tensp = anphuoc.Tensp;
                result.Hoatiet = anphuoc.Hoatiet;
                result.Gia = anphuoc.Gia;
                result.Thongtin = anphuoc.Thongtin;
                result.LoaispId = anphuoc.LoaispId;
                result.Hinhanh = anphuoc.Hinhanh;
                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task<AnPhuoc> DeleteAnPhuoc(int anphuocId)
        {
            var result = await appDbContext.AnPhuocs
                .FirstOrDefaultAsync(a => a.AnPhuocId == anphuocId);
            if (result != null)
            {
                appDbContext.AnPhuocs.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }
            else 
                return null;
        }
    }
}
