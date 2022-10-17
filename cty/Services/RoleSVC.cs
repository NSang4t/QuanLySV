using cty.Interfaces;
using cty.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cty.Services
{
    public class RoleSVC : IRole
    {
        protected DataContext _context;
        protected IEncode _mahoaHelper;
        public RoleSVC(DataContext context, IEncode mahoaHelper)
        {
            _context = context;
            _mahoaHelper = mahoaHelper;
        }

        public async Task<int> AddRole(Roles role)
        {
            int ret = 0;
            try
            {
                _context.Add(role);
                await _context.SaveChangesAsync();
                ret = role.Id;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
        public Roles GetRoleID(int id)
        {
            Roles role = null;
            role = _context.roless.Find(id);
            return role;
        }
        public async Task<int> DeleteRole(int id)
        {

            int ret = 0;
            try
            {
                var a = GetRoleID(id);
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

        public async Task<int> EditRole(int id, Roles role)
        {
            int ret = 0;
            try
            {
                Roles st = new Roles();
                st = await _context.roless.Where(a => a.Id == st.Id).FirstOrDefaultAsync();
                _context.Update(role);
                await _context.SaveChangesAsync();
                ret = role.Id;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public  async Task<List<Roles>> GetAllRole()
        {
            List<Roles> list = new List<Roles>();
            list = await _context.roless.ToListAsync();
            return list;
        }

       
    }
}
