﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cty.Models;

namespace cty.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220830082026_CompanyDB")]
    partial class CompanyDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cty.Models.CT_Class", b =>
                {
                    b.Property<int>("ID_CT_CLass")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Caidatkhac")
                        .HasColumnType("int");

                    b.Property<int>("ID_CLass")
                        .HasColumnType("int");

                    b.Property<DateTime>("Lichthi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name_CLass")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name_teacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("Ngaybatdau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ngayketthuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("PassWord_LH")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("soluong")
                        .HasColumnType("float");

                    b.Property<double>("thoigian")
                        .HasColumnType("float");

                    b.HasKey("ID_CT_CLass");

                    b.ToTable("CT_Classs");
                });

            modelBuilder.Entity("cty.Models.LopHoc", b =>
                {
                    b.Property<int>("ID_CLass")
                        .HasColumnType("int");

                    b.Property<double>("Diem")
                        .HasColumnType("float");

                    b.Property<string>("Name_Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name_mon")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("Ngaythamgia")
                        .HasColumnType("datetime2");

                    b.Property<int>("Trangthai")
                        .HasColumnType("int");

                    b.Property<int?>("semestersID_Semester")
                        .HasColumnType("int");

                    b.HasKey("ID_CLass");

                    b.HasIndex("semestersID_Semester");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("cty.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("roless");
                });

            modelBuilder.Entity("cty.Models.Semester", b =>
                {
                    b.Property<int>("ID_Semester")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name_Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name_Semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("usermodelsUser_ID")
                        .HasColumnType("int");

                    b.HasKey("ID_Semester");

                    b.HasIndex("usermodelsUser_ID");

                    b.ToTable("KyHoc");
                });

            modelBuilder.Entity("cty.Models.Student", b =>
                {
                    b.Property<int>("ID_Student")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Hinh")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("Char(15)");

                    b.Property<string>("nam_bd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nam_kt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("semestersID_Semester")
                        .HasColumnType("int");

                    b.Property<int?>("usermodelsUser_ID")
                        .HasColumnType("int");

                    b.HasKey("ID_Student");

                    b.HasIndex("semestersID_Semester");

                    b.HasIndex("usermodelsUser_ID");

                    b.ToTable("Hocsinh");
                });

            modelBuilder.Entity("cty.Models.UserModel", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("User_ID");

                    b.HasIndex("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("cty.Models.LopHoc", b =>
                {
                    b.HasOne("cty.Models.CT_Class", "CT_Classs")
                        .WithOne("lophocs")
                        .HasForeignKey("cty.Models.LopHoc", "ID_CLass")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cty.Models.Semester", "semesters")
                        .WithMany("lophocs")
                        .HasForeignKey("semestersID_Semester");
                });

            modelBuilder.Entity("cty.Models.Semester", b =>
                {
                    b.HasOne("cty.Models.UserModel", "usermodels")
                        .WithMany("semesters")
                        .HasForeignKey("usermodelsUser_ID");
                });

            modelBuilder.Entity("cty.Models.Student", b =>
                {
                    b.HasOne("cty.Models.Semester", "semesters")
                        .WithMany("students")
                        .HasForeignKey("semestersID_Semester");

                    b.HasOne("cty.Models.UserModel", "usermodels")
                        .WithMany()
                        .HasForeignKey("usermodelsUser_ID");
                });

            modelBuilder.Entity("cty.Models.UserModel", b =>
                {
                    b.HasOne("cty.Models.Roles", "role")
                        .WithMany()
                        .HasForeignKey("Id");
                });
#pragma warning restore 612, 618
        }
    }
}
