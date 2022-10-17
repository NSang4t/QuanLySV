using cty.Models;
using cty.Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM.Share.Interfaces
{
    public interface Istudent
    {

        Student Login(ViewLogin viewLogin);

        Task<List<Student>> GetAllStudent();
        Task<int> AddStudent(Student student);
        Task<int> EditStudent(int id, Student student);
        Task<int> DeleteStudent(int id);


    }
}
