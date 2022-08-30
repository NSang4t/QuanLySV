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
        public DbSet<Roles> roless { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<LopHoc> LopHocs { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<CT_Class> CT_Classs { get; set; }
    }

}

