using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace cty.Models
{
    [Table("Hocsinh")]
    public class Student
    {
        [Key]
        public int ID_Student { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập email."), DataType(DataType.EmailAddress)]
        [StringLength(30)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập họ và tên")]
        [Display(Name = "Họ và Tên")]
        [StringLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn ngày sinh")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Ngày sinh")]
        public DateTime BirthDay { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn giới tính")]
        [Display(Name = "Giới tính")]
        public Gender Gender { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ.")]
        [StringLength(255), Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Column(TypeName = "Char(15)"), Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Bạn cần nhập số điện thoại của mình.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [Column(TypeName = "varchar(50)"), MinLength(6, ErrorMessage = "Mật khẩu từ 6-12 kí tự")]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập lại mật khẩu.")]
        [Column(TypeName = "varchar(50)"), MinLength(6, ErrorMessage = "Mật khẩu từ 6-12 kí tự")]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage = "Mật khẩu không trùng khớp!!!")]
        [NotMapped]
        public string RetypePassWord { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập năm bắt đầu học")]
        [DisplayFormat(DataFormatString = "{yyyy}")]
        [Display(Name = "Năm bắt đầu")]
        public string nam_bd { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập năm kết thúc học")]
        [DisplayFormat(DataFormatString = "{yyyy}")]
        [Display(Name = "Năm kết thúc")]
        public string nam_kt { get; set; }

        [/*Required(ErrorMessage = "Nhập Tên Ảnh"), */Display(Name = "Hình Ảnh")]
        [Column(TypeName = "varchar(200)"), MaxLength(100)]
        public string Hinh { get; set; }

        [NotMapped]
        [Display(Name = "Chọn Hình")]
        public IFormFile ImageFile { get; set; }

        public Semester Semester{ get; set; }
        // public UserModel usermodels { get; set; }
    }
}
