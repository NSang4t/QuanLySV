using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cty.Models
{
    public enum CaiDat
    {
        [Display(Name = "Tự Động kích hoạt buổi học khi đến thời gian bắt đầu")]
        tu = 1,
        [Display(Name = "Bật tính năng lưu lại buổi học ")]
        luu = 2,
       
    }
    public class CT_Class
    {
        [Key]
        public int ID_CT_CLass { get; set; }

        [ForeignKey("LichThi")]
        public int LichThiID { get; set; }

        public int ID_CLass { get; set; }
        // public int IDTeacher { get; set; }
      

        [Required(ErrorMessage = "Bạn cần nhập tên giáo viên ")]
        [Display(Name = "tên giáo viên ")]
        [StringLength(30)]
        public string Name_teacher { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên môn học")]
        [Display(Name = "tên môn học")]
        [StringLength(30)]
        public string Name_CLass { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập mô tả môn học")]
        [Display(Name = "mô tả môn học")]
        [StringLength(100)]
        public string mota { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần số lượng buổi học")]
        [Display(Name = "Số lượng ")]
        public double soluong { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần thời gian của buổi học")]
        [Display(Name = "thời gian ")]
        public double thoigian  { get; set; }

        [Required(ErrorMessage = "Bạn cần chọn ngày bắt đầu"), Display(Name = "Ngày bắt đầu")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngaybatdau{ get; set; }

        [Required(ErrorMessage = "Bạn cần chọn ngày kết thúc"), Display(Name = "Ngày kết thúc")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngayketthuc { get; set; }


        [Required(ErrorMessage = "Bạn cần chọn ngày thi"), Display(Name = "Ngày thi")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Lichthi { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu của lớp học ")]
        [Column(TypeName = "varchar(50)"), MinLength(6, ErrorMessage = "Mật khẩu từ 6-12 kí tự")]
        [DataType(DataType.Password)]
        public string PassWord_LH { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập link chia sẻ")]
        [Display(Name = "mô tả môn học")]
        [StringLength(150)]
        public string link { get; set; }

        [Display(Name = "Các Cài Đặt")]
        public CaiDat Caidatkhac { get; set; }

        public LopHoc lophocs { get; set; }

        public LichThi LichThis { get; set; }
    }
}
