using ASM.Share.Interfaces;
using cty.Helpers;
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
    public class StudentSVC : Istudent
    {
        protected DataContext _context;
        protected IEncode _mahoaHelper;
        public StudentSVC(DataContext context, IEncode mahoaHelper)
        {
            _context = context;
            _mahoaHelper = mahoaHelper;
        }

        public async Task<int> AddStudent(Student student)
        {
            int ret = 0;
            try
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                ret = student.ID_Student;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
        public Student GetStudentIdFind(int id)
        {
            Student student = null;
            student = _context.students.Find(id);
            return student;
        }
        public async Task<int> DeleteStudent(int id)
        {
            int ret = 0;
            try
            {
                var a = GetStudentIdFind(id);
                _context.Remove(a);
                await _context.SaveChangesAsync();
                ret = a.ID_Student;
               
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> EditStudent(int id, Student student)
        {
            int ret = 0;
            try
            {
                Student st = new Student();
                st = await _context.students.Where(a => a.ID_Student == st.ID_Student).FirstOrDefaultAsync();
                _context.Update(student);
                await _context.SaveChangesAsync();
                ret = student.ID_Student;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret; 
        }

        public async Task<List<Student>> GetAllStudent()
        {
            List<Student> list = new List<Student>();
            list = await _context.students.ToListAsync();
            return list;
        }

        public int KHEditStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }

     
        public Student Login(ViewLogin viewLogin)
        {
            var user = _context.students.Where(
               p => p.Name.Equals(viewLogin.UserName)
               && p.PassWord.Equals(_mahoaHelper.Encode(viewLogin.Password))
               ).FirstOrDefault();
            return user;
        }
    }
}
