using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cty.Migrations
{
    public partial class CompanyDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CT_Classs",
                columns: table => new
                {
                    ID_CT_CLass = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    semestersID_Semester = table.Column<int>(nullable: true),
                    usermodelsUser_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hocsinh", x => x.ID_Student);
                    table.ForeignKey(
                        name: "FK_Hocsinh_KyHoc_semestersID_Semester",
                        column: x => x.semestersID_Semester,
                        principalTable: "KyHoc",
                        principalColumn: "ID_Semester",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hocsinh_Users_usermodelsUser_ID",
                        column: x => x.usermodelsUser_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
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
                name: "IX_Hocsinh_semestersID_Semester",
                table: "Hocsinh",
                column: "semestersID_Semester");

            migrationBuilder.CreateIndex(
                name: "IX_Hocsinh_usermodelsUser_ID",
                table: "Hocsinh",
                column: "usermodelsUser_ID");

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
                name: "Hocsinh");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "CT_Classs");

            migrationBuilder.DropTable(
                name: "KyHoc");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "roless");
        }
    }
}
