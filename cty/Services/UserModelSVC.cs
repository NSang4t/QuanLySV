using cty.Interfaces;
using cty.Models;
using cty.Share.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cty.Services
{
    public class UserModelSVC : IUserModels
    {
        protected DataContext _context;
        protected IEncode _enCode;
        public UserModelSVC(DataContext context, IEncode enCode)
        {
            _context = context;
            _enCode = enCode;
        }

        public async Task<int> AddUserModel(UserModel user)
        {
            int ret = 0;
            try
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                ret = user.User_ID;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
        public UserModel GetEmail(string email)
        {
            UserModel user = null;
            user = _context.UserModels.FirstOrDefault(m => m.Email == email);
            return user;
        }
        public async Task<int> ChangePasswordAdmin(string email, UserModel userModel)
        {
            int ret = 0;
            try
            {
                UserModel _cus = null;
                _cus = GetEmail(email);

                _cus.Password = _enCode.Encode(userModel.Password);

                _context.Update(_cus);
                await _context.SaveChangesAsync();
                ret = userModel.User_ID;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> DeleteUserModel(int id)
        {
            int ret = 0;
            try
            {
                var a = GetUserIdFind(id);
                _context.Remove(a);
                await _context.SaveChangesAsync();
                ret = a.User_ID;

            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> EditUserModel(int id, UserModel user)
        {
            int ret = 0;
            try
            {
                UserModel st = new UserModel();
                st = await _context.UserModels.Where(a => a.User_ID == st.User_ID).FirstOrDefaultAsync();
                _context.Update(user);
                await _context.SaveChangesAsync();
                ret = user.User_ID;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
        public UserModel GetUserIdFind(int id)
        {
            UserModel user = null;
            user = _context.UserModels.Find(id);
            return user;
        }
        public async Task<List<UserModel>> GetAllUserModel()
        {
            List<UserModel> customer = new List<UserModel>();
            customer = await _context.UserModels.ToListAsync();
            return customer;
        }

        public UserModel login(ViewWebLogin viewWebLogin)
        {
            var loginAdmin = _context.UserModels.Where(
              p => p.Email.Equals(viewWebLogin.Email)
              && p.Password.Equals(viewWebLogin.Password)
              ).FirstOrDefault();

            return loginAdmin;
        }
    }
}
