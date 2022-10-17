using cty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cty.Interfaces
{
    public interface ICLass
    {
        Task<List<LopHoc>> GetAllClass();
        Task<int> AddClass(LopHoc lop);
        Task<int> EditClass(int id, LopHoc lop);
        Task<int> DeleteClass(int id);
    }
}
