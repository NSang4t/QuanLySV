using cty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cty.Interfaces
{
   public interface IRole
    {
        Task<List<Roles>> GetAllRole();
        Task<int> AddRole(Roles role);
        Task<int> EditRole(int id, Roles role);
        Task<int> DeleteRole(int id);
    }
}
