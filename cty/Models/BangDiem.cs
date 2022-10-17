using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace cty.Models
{
    public class BangDiem
    {
        [Key]
        public int BangDiemID { get; set; }
        [ForeignKey("BaiKiemTra")]
        public int BaiThiID { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên môn học")]
        [Display(Name = "tên môn học")]
        [StringLength(30)]
        public string Name_CLass { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập tên giáo viên ")]
        [Display(Name = "tên giáo viên ")]
        [StringLength(30)]
        public string Name_teacher { get; set; }


        [Required(ErrorMessage = "Bạn cần chọn ngày"), Display(Name = "Ngày Cập Nhật Điểm ")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ngaythamgia { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập vào điểm chuyên cần ")]
        [Display(Name = "Điểm chuyên cần ")]
        [StringLength(30)]
        public float DiemChuyenCan { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập vào điểm miệng  ")]
        [Display(Name = "Điểm miệng ")]
        [StringLength(30)]
        public float DiemMieng { get; set; }


        [Required(ErrorMessage = "Bạn cần nhập vào điểm  15 phút  ")]
        [Display(Name = "điểm 15 phút ")]
        [StringLength(30)]
        public float Diem15P{ get; set; }


        [Required(ErrorMessage = "Bạn cần nhập vào điểm hệ số II  ")]
        [Display(Name = "điểm hệ số II ")]
        [StringLength(30)]
        public float DiemHeSoII { get; set; }

        
        [Required(ErrorMessage = "Bạn cần nhập vào điểm  III ")]
        [Display(Name = "Điểm hệ số  III  ")]
        [StringLength(30)]
        public float DiemHeSoIII { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập vào điểm trung bình  ")]
        [Display(Name = "điểm trung bình  ")]
        [StringLength(30)]
        public float DiemTrungBinh { get; set; }

        public BaiKiemTra BaiKiemTra { get; set; }

    }
}
