using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cty.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Roles> roless { get; set; }//sbcđ
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<LopHoc> LopHocs { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<CT_Class> CT_Classs { get; set; }
        public DbSet< BangDiem> BangDiems { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<BaiKiemTra> baiKiemTras { get; set; }
        public DbSet<LichThi> lichThis { get; set; }

    }

}

