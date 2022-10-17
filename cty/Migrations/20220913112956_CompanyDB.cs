using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cty.Migrations
{
    public partial class CompanyDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lichThis",
                columns: table => new
                {
                    LichThiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_CLass = table.Column<string>(maxLength: 30, nullable: false),
                    ChonKhoi = table.Column<int>(nullable: false),
                    Name_teacher = table.Column<string>(maxLength: 30, nullable: false),
                    thoigian = table.Column<double>(nullable: false),
                    NoiDung = table.Column<string>(maxLength: 50, nullable: false),
                    HinhThuc = table.Column<int>(nullable: false),
                    LocLichThi = table.Column<int>(nullable: false),
                    Trangthai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lichThis", x => x.LichThiID);
                });

            migrationBuilder.CreateTable(
                name: "roless",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roless", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "baiKiemTras",
                columns: table => new
                {
                    BaiThiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LichThiID = table.Column<int>(nullable: false),
                    Name_CLass = table.Column<string>(maxLength: 30, nullable: false),
                    Name_teacher = table.Column<string>(maxLength: 30, nullable: false),
                    Ngay = table.Column<DateTime>(nullable: false),
                    ChonKhoi = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(maxLength: 50, nullable: false),
                    thoigian = table.Column<double>(nullable: false),
                    Trangthai = table.Column<int>(nullable: false),
                    CacCauhoi = table.Column<string>(maxLength: 50, nullable: false),
                    Noidungcauhoi = table.Column<string>(maxLength: 50, nullable: false),
                    Diem = table.Column<float>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baiKiemTras", x => x.BaiThiID);
                    table.ForeignKey(
                        name: "FK_baiKiemTras_lichThis_LichThiID",
                        column: x => x.LichThiID,
                        principalTable: "lichThis",
                        principalColumn: "LichThiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CT_Classs",
                columns: table => new
                {
                    ID_CT_CLass = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LichThiID = table.Column<int>(nullable: false),
                    ID_CLass = table.Column<int>(nullable: false),
                    Name_teacher = table.Column<string>(maxLength: 30, nullable: false),
                    Name_CLass = table.Column<string>(maxLength: 30, nullable: false),
                    mota = table.Column<string>(maxLength: 100, nullable: false),
                    soluong = table.Column<double>(nullable: false),
                    thoigian = table.Column<double>(nullable: false),
                    Ngaybatdau = table.Column<DateTime>(nullable: false),
                    Ngayketthuc = table.Column<DateTime>(nullable: false),
                    Lichthi = table.Column<DateTime>(nullable: false),
                    PassWord_LH = table.Column<string>(type: "varchar(50)", nullable: false),
                    link = table.Column<string>(maxLength: 150, nullable: false),
                    Caidatkhac = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_Classs", x => x.ID_CT_CLass);
                    table.ForeignKey(
                        name: "FK_CT_Classs_lichThis_LichThiID",
                        column: x => x.LichThiID,
                        principalTable: "lichThis",
                        principalColumn: "LichThiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    GioiTinh = table.Column<int>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    DiaChi = table.Column<string>(maxLength: 200, nullable: false),
                    DienThoai = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_Users_roless_Id",
                        column: x => x.Id,
                        principalTable: "roless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BangDiems",
                columns: table => new
                {
                    BangDiemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaiThiID = table.Column<int>(nullable: false),
                    Name_CLass = table.Column<string>(maxLength: 30, nullable: false),
                    Name_teacher = table.Column<string>(maxLength: 30, nullable: false),
                    Ngaythamgia = table.Column<DateTime>(nullable: false),
                    DiemChuyenCan = table.Column<float>(maxLength: 30, nullable: false),
                    DiemMieng = table.Column<float>(maxLength: 30, nullable: false),
                    Diem15P = table.Column<float>(maxLength: 30, nullable: false),
                    DiemHeSoII = table.Column<float>(maxLength: 30, nullable: false),
                    DiemHeSoIII = table.Column<float>(maxLength: 30, nullable: false),
                    DiemTrungBinh = table.Column<float>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangDiems", x => x.BangDiemID);
                    table.ForeignKey(
                        name: "FK_BangDiems_baiKiemTras_BaiThiID",
                        column: x => x.BaiThiID,
                        principalTable: "baiKiemTras",
                        principalColumn: "BaiThiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KyHoc",
                columns: table => new
                {
                    ID_Semester = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Semester = table.Column<string>(maxLength: 30, nullable: false),
                    Name_Class = table.Column<string>(maxLength: 30, nullable: false),
                    usermodelsUser_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KyHoc", x => x.ID_Semester);
                    table.ForeignKey(
                        name: "FK_KyHoc_Users_usermodelsUser_ID",
                        column: x => x.usermodelsUser_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hocsinh",
                columns: table => new
                {
                    ID_Student = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 255, nullable: false),
                    PhoneNo = table.Column<string>(type: "Char(15)", nullable: false),
                    PassWord = table.Column<string>(type: "varchar(50)", nullable: false),
                    nam_bd = table.Column<string>(nullable: false),
                    nam_kt = table.Column<string>(nullable: false),
                    Hinh = table.Column<string>(type: "varchar(200)", maxLength: 100, nullable: true),
                    SemesterID_Semester = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hocsinh", x => x.ID_Student);
                    table.ForeignKey(
                        name: "FK_Hocsinh_KyHoc_SemesterID_Semester",
                        column: x => x.SemesterID_Semester,
                        principalTable: "KyHoc",
                        principalColumn: "ID_Semester",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    ID_CLass = table.Column<int>(nullable: false),
                    Name_mon = table.Column<string>(maxLength: 30, nullable: false),
                    Name_Class = table.Column<string>(maxLength: 30, nullable: false),
                    Diem = table.Column<double>(nullable: false),
                    Ngaythamgia = table.Column<DateTime>(nullable: false),
                    Trangthai = table.Column<int>(nullable: false),
                    semestersID_Semester = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.ID_CLass);
                    table.ForeignKey(
                        name: "FK_LopHoc_CT_Classs_ID_CLass",
                        column: x => x.ID_CLass,
                        principalTable: "CT_Classs",
                        principalColumn: "ID_CT_CLass",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LopHoc_KyHoc_semestersID_Semester",
                        column: x => x.semestersID_Semester,
                        principalTable: "KyHoc",
                        principalColumn: "ID_Semester",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_baiKiemTras_LichThiID",
                table: "baiKiemTras",
                column: "LichThiID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BangDiems_BaiThiID",
                table: "BangDiems",
                column: "BaiThiID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CT_Classs_LichThiID",
                table: "CT_Classs",
                column: "LichThiID");

            migrationBuilder.CreateIndex(
                name: "IX_Hocsinh_SemesterID_Semester",
                table: "Hocsinh",
                column: "SemesterID_Semester");

            migrationBuilder.CreateIndex(
                name: "IX_KyHoc_usermodelsUser_ID",
                table: "KyHoc",
                column: "usermodelsUser_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_semestersID_Semester",
                table: "LopHoc",
                column: "semestersID_Semester");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                table: "Users",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangDiems");

            migrationBuilder.DropTable(
                name: "Hocsinh");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "baiKiemTras");

            migrationBuilder.DropTable(
                name: "CT_Classs");

            migrationBuilder.DropTable(
                name: "KyHoc");

            migrationBuilder.DropTable(
                name: "lichThis");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "roless");
        }
    }
}
