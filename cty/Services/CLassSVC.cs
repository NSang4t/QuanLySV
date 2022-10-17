using cty.Interfaces;
using cty.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cty.Services
{
    public class CLassSVC : ICLass
    {
        protected DataContext _context;
        protected IEncode _mahoaHelper;
        public CLassSVC(DataContext context, IEncode mahoaHelper)
        {
            _context = context;
            _mahoaHelper = mahoaHelper;
        }
        public Roles GetClassID(int id)
        {
            Roles role = null;
            role = _context.roless.Find(id);
            return role;
        }
        public async Task<int> AddClass(LopHoc lop)
        {
            int ret = 0;
            try
            {
                _context.Add(lop);
                await _context.SaveChangesAsync();
                ret = lop.ID_CLass;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> DeleteClass(int id)
        {
            int ret = 0;
            try
            {
                var a = GetClassID(id);
                _context.Remove(a);
                await _context.SaveChangesAsync();
                ret = a.Id;

            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> EditClass(int id, LopHoc lop)
        {
            int ret = 0;
            try
            {
                LopHoc st = new LopHoc();
                st = await _context.LopHocs.Where(a => a.ID_CLass == st.ID_CLass).FirstOrDefaultAsync();
                _context.Update(lop);
                await _context.SaveChangesAsync();
                ret = lop.ID_CLass;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<List<LopHoc>> GetAllClass()
        {
            List<LopHoc> list = new List<LopHoc>();
            list = await _context.LopHocs.ToListAsync();
            return list;
        }
    }
}
