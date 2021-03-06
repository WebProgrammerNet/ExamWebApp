﻿// <auto-generated />
using System;
using ExamWebApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamWebApp.Migrations
{
    [DbContext(typeof(ExamDbContext))]
    [Migration("20200621111654_AppInitial_12")]
    partial class AppInitial_12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamWebApp.Models.Exam", b =>
                {
                    b.Property<string>("ExamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ExamDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ExamId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExamWebApp.Models.ExofSt", b =>
                {
                    b.Property<string>("ExofStId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ExamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ExofStId");

                    b.HasIndex("ExamId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ExofSts");
                });

            modelBuilder.Entity("ExamWebApp.Models.Grade", b =>
                {
                    b.Property<string>("GradeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Letter")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<byte>("MaxGrade")
                        .HasColumnType("tinyint");

                    b.Property<byte>("MinGrade")
                        .HasColumnType("tinyint");

                    b.HasKey("GradeId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            GradeId = "b3254576-be44-4a4f-bb2c-665f5b89c935",
                            Letter = "A",
                            MaxGrade = (byte)100,
                            MinGrade = (byte)91
                        },
                        new
                        {
                            GradeId = "55792e08-4bd0-4b80-b777-a4f5798e160a",
                            Letter = "B",
                            MaxGrade = (byte)90,
                            MinGrade = (byte)81
                        },
                        new
                        {
                            GradeId = "6d8e2216-138b-42b2-a001-9df60a21b2ca",
                            Letter = "C",
                            MaxGrade = (byte)80,
                            MinGrade = (byte)71
                        },
                        new
                        {
                            GradeId = "f384726d-126e-44ed-9010-0e9bf3dbb24c",
                            Letter = "D",
                            MaxGrade = (byte)70,
                            MinGrade = (byte)61
                        },
                        new
                        {
                            GradeId = "b7227970-b1ba-4f1f-9219-9aaa40b71647",
                            Letter = "E",
                            MaxGrade = (byte)60,
                            MinGrade = (byte)51
                        },
                        new
                        {
                            GradeId = "29c4861d-1bb3-47f7-ad65-118908c2c21d",
                            Letter = "F",
                            MaxGrade = (byte)50,
                            MinGrade = (byte)0
                        });
                });

            modelBuilder.Entity("ExamWebApp.Models.Group", b =>
                {
                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SchoolClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GroupId");

                    b.HasIndex("SchoolClassId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ExamWebApp.Models.SchoolClass", b =>
                {
                    b.Property<string>("SchoolClassId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolClassId");

                    b.ToTable("SchoolClasses");

                    b.HasData(
                        new
                        {
                            SchoolClassId = "e4d67924-dab2-41dd-b190-73e01e481890",
                            Nth = "First"
                        },
                        new
                        {
                            SchoolClassId = "ffb9d291-cfc0-446f-a709-06ef6ec066d9",
                            Nth = "Second"
                        },
                        new
                        {
                            SchoolClassId = "1926320c-4f68-4ee9-9d11-96490247b98c",
                            Nth = "Third"
                        },
                        new
                        {
                            SchoolClassId = "eb32e50d-7672-448e-9d41-b63922bb6af5",
                            Nth = "Fourth"
                        },
                        new
                        {
                            SchoolClassId = "51d211c5-3e8f-48a4-86a2-d990d8d64516",
                            Nth = "Fifth"
                        },
                        new
                        {
                            SchoolClassId = "e574d694-3080-48a3-8468-7f03f7060435",
                            Nth = "Sixth"
                        },
                        new
                        {
                            SchoolClassId = "599fe92a-9d87-44f9-96a3-5fe09b93a70f",
                            Nth = "Seventh"
                        },
                        new
                        {
                            SchoolClassId = "ab3be4dd-4cf7-4140-8620-6a2d81b41273",
                            Nth = "Eighth"
                        },
                        new
                        {
                            SchoolClassId = "0f587bd7-e5d3-4867-bde4-4d41c8855b9a",
                            Nth = "Ninth"
                        },
                        new
                        {
                            SchoolClassId = "25425cff-bf62-4ab7-99a4-f6913b9e1a8d",
                            Nth = "Tenth"
                        },
                        new
                        {
                            SchoolClassId = "81d3fb6e-5101-4795-848d-3f1be65cfa92",
                            Nth = "Eleventh"
                        });
                });

            modelBuilder.Entity("ExamWebApp.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<byte?>("Mark")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("StudentId");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ExamWebApp.Models.Subject", b =>
                {
                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectId = "3bf01a19-116a-447b-bbd4-a6defb9b6e7e",
                            Name = "AnaDili"
                        },
                        new
                        {
                            SubjectId = "653268e8-2bdb-4519-aeaf-ec36f44a60d1",
                            Name = "Ədəbiyyat"
                        },
                        new
                        {
                            SubjectId = "21b4bd7d-234c-4b3e-becc-7b6f2be8fdd3",
                            Name = "Tarix"
                        },
                        new
                        {
                            SubjectId = "99fe023f-9726-4d52-9fa8-b02a69c32b84",
                            Name = "Rus_Dili"
                        },
                        new
                        {
                            SubjectId = "ea272dea-bb8d-4071-9011-2d9d65a87a4a",
                            Name = "Ingilis_Dili"
                        },
                        new
                        {
                            SubjectId = "0d3ccf00-9cab-43a3-9ce3-5c7a0c263b73",
                            Name = "Fizika"
                        },
                        new
                        {
                            SubjectId = "effba506-a163-4fa3-afce-235e75b8f48e",
                            Name = "Coğrayiya"
                        },
                        new
                        {
                            SubjectId = "09682ec6-67d1-4e92-9979-1c55d0820249",
                            Name = "Kimya"
                        },
                        new
                        {
                            SubjectId = "5018163c-4370-405e-b81d-ac9b883aea57",
                            Name = "Cəbr"
                        },
                        new
                        {
                            SubjectId = "a4d98e33-fcbc-4d5b-b0a2-379758900c7f",
                            Name = "Həndəsə"
                        });
                });

            modelBuilder.Entity("ExamWebApp.Models.Teacher", b =>
                {
                    b.Property<string>("TeacherId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("TeacherId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ExamWebApp.Models.Worker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ExamWebApp.Models.Exam", b =>
                {
                    b.HasOne("ExamWebApp.Models.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("ExamWebApp.Models.ExofSt", b =>
                {
                    b.HasOne("ExamWebApp.Models.Exam", "Exam")
                        .WithMany("ExofSts")
                        .HasForeignKey("ExamId");

                    b.HasOne("ExamWebApp.Models.Student", "Student")
                        .WithMany("ExofSts")
                        .HasForeignKey("StudentId");

                    b.HasOne("ExamWebApp.Models.Teacher", "Teacher")
                        .WithMany("ExofSts")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("ExamWebApp.Models.Group", b =>
                {
                    b.HasOne("ExamWebApp.Models.SchoolClass", "SchoolClass")
                        .WithMany("Groups")
                        .HasForeignKey("SchoolClassId");

                    b.HasOne("ExamWebApp.Models.Teacher", "Teacher")
                        .WithMany("Groups")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("ExamWebApp.Models.Student", b =>
                {
                    b.HasOne("ExamWebApp.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("ExamWebApp.Models.Teacher", b =>
                {
                    b.HasOne("ExamWebApp.Models.Subject", "Subject")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ExamWebApp.Models.Worker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ExamWebApp.Models.Worker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExamWebApp.Models.Worker", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ExamWebApp.Models.Worker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
