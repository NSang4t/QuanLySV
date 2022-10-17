using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cty.Models
{
    public enum LocLichThi
    {
        [Display(Name = "Kiểm tra 15 phút")]
        thi1 = 1,
        [Display(Name = "Kiểm tra 45 phút ")]
        thi2 = 2,
        [Display(Name = "Kiểm tra Học Kỳ ")]
        thi3= 3,
        [Display(Name = "Kiểm tra cuối kỳ ")]
        thi4 = 4,

    }
    public enum HinhThucThi
    {
        [Display(Name = "Thi Tự Luận")]
        hinhthuc = 1,
        [Display(Name = "Thi Trắc Nghiệm ")]
        hinhthuc1 = 2,
        [Display(Name = "Thi Trắc Nghiệm  Và Tự Luận")]
        hinhthuc2 = 3,
    }
    public enum TrangThaiThi
    {
        [Display(Name = "Đã Hoàn thành")]
        hinhthuc = 1,
        [Display(Name = "Chưa hoàn thành")]
        hinhthuc1 = 2,
        [Display(Name = "chưa bắt đầu")]
        hinhthuc2 = 3,
    }
    public enum Khoilop
    {
        [Display(Name = "10")]
        hinhthuc = 1,
        [Display(Name = "11")]
        hinhthuc1 = 2,
        [Display(Name = "12")]
        hinhthuc2 = 3,
    }
    public class LichThi
    {
        [Key]
        public int  LichThiID { get; set; }
        
       
        [Required(ErrorMessage = "Bạn cần nhập tên môn học")]
        [Display(Name = "tên môn học")]
        [StringLength(30)]
        public string Name_CLass { get; set; }

        [Required(ErrorMessage = "Bạn cần chọn khối")]
        [Display(Name = "tên môn học")]
        public Khoilop ChonKhoi{ get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên giáo viên ")]
        [Display(Name = "tên giáo viên ")]
        [StringLength(30)]
        public string Name_teacher { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần thời gian của Buổi thi")]
        [Display(Name = "thời gian ")]
        public double thoigian { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập Nội Dung ")]
        [Display(Name = "Nội Dung Thi ")]
        [StringLength(50)]
        public string NoiDung { get; set; }


        [Display(Name = "Hình Thức")]
        public HinhThucThi HinhThuc { get; set; }

        [Display(Name = "Lọc Lịch Thi")]
        public LocLichThi LocLichThi { get; set; }


        [Display(Name = "Trạng thái Thi")]
        public TrangThaiThi Trangthai { get; set; }

        public ICollection< CT_Class> CT_Classs { get; set; }

        public BaiKiemTra BaiKiemTra { get; set; }

    }
}
