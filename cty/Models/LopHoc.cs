using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace cty.Models
{
    public enum TrangThaiHoc
    {
        [Display(Name = "Chưa Tham Gia")]
        Chua = 1,
        [Display(Name = "Đang Học ")]
        Dang = 2,
        [Display(Name = "Đã Hoàn Thành")]
        Da = 3
    }
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key , ForeignKey("CT_Classs")]
        public int ID_CLass { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên môn học")]
        [Display(Name = "tên môn học")]
        [StringLength(30)]
        public string Name_mon { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên lớp học")]
        [Display(Name = "tên lớp học")]
        [StringLength(30)]
        public string Name_Class { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần điểm môn học")]
        [Display(Name = "Điểm")]
        public double Diem { get; set; }

        [Required(ErrorMessage = "Bạn cần chọn ngày"), Display(Name = "Ngày Tham Gia")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngaythamgia { get; set; }

        [Display(Name = "Trạng Thái")]
        public TrangThaiHoc Trangthai { get; set; }

        public Semester semesters { get; set; }

        public CT_Class CT_Classs { get; set; }
    }
}
