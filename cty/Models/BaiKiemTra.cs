using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace cty.Models
{
    public enum Khoilop1
    {
        [Display(Name = "10")]
        hinhthuc = 1,
        [Display(Name = "11")]
        hinhthuc1 = 2,
        [Display(Name = "12")]
        hinhthuc2 = 3,
    }
    public enum TrangThaicham
    {
        [Display(Name = "Bắt dầu")]
        hinhthuc = 1,
        [Display(Name = "chấm điểm ")]
        hinhthuc1 = 2,
        [Display(Name = "nhập điểm")]
        hinhthuc2 = 3,
    }
    public class BaiKiemTra
    {
        [Key]
        public int BaiThiID { get; set; }

        [ForeignKey("LichThi")]
        public int LichThiID { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên môn học")]
        [Display(Name = "tên môn học")]
        [StringLength(30)]
        public string Name_CLass { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên giáo viên ")]
        [Display(Name = "tên giáo viên ")]
        [StringLength(30)]
        public string Name_teacher { get; set; }

        [Required(ErrorMessage = "Bạn cần chọn ngày"), Display(Name = "Ngày ")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngay { get; set; }

        [Required(ErrorMessage = "Bạn cần chọn khối")]
        [Display(Name = "tên môn học")]
        public Khoilop1 ChonKhoi { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập Nội Dung ")]
        [Display(Name = "Nội Dung Thi ")]
        [StringLength(50)]
        public string NoiDung { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần thời gian của Buổi thi")]
        [Display(Name = "thời gian ")]
        public double thoigian { get; set; }

        [Display(Name = "Trạng thái Thi")]
        public TrangThaicham Trangthai { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập Các câu hỏi ")]
        [Display(Name = "các câu hỏi ")]
        [StringLength(50)]
        public string CacCauhoi { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập nội dung câu hỏi ")]
        [Display(Name = "nội dung  câu hỏi ")]
        [StringLength(50)]
        public string Noidungcauhoi { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập vào Điểm")]
        [Display(Name = "điểm  ")]
        [StringLength(30)]
        public float Diem { get; set; }

        public BangDiem BangDiem { get; set; }


        public LichThi LichThi { get; set; }
    }
}
