using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace cty.Models
{
    [Table("KyHoc")]
    public class Semester // kyhoc
    {
        [Key]
        public int ID_Semester { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên kỳ học")]
        [Display(Name = "tên môn học")]
        [StringLength(30)]
        public string Name_Semester { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên lớp học")]
        [Display(Name = "tên lớp học")]
        [StringLength(30)]
        public string Name_Class { get; set; }

        public ICollection<LopHoc> lophocs { get; set; }
        public ICollection<Student> students { get; set; }

          public UserModel usermodels { get; set; }

    }
}
