using ExamWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.DAL
{
    public class ExamDbContext : IdentityDbContext<Worker>
    {
        public ExamDbContext(DbContextOptions<ExamDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SchoolClass>().HasData(
                 new SchoolClass { Nth = "First" },
                 new SchoolClass { Nth = "Second" },
                 new SchoolClass { Nth = "Third" },
                 new SchoolClass { Nth = "Fourth" },
                 new SchoolClass { Nth = "Fifth" },
                 new SchoolClass { Nth = "Sixth" },
                 new SchoolClass { Nth = "Seventh" },
                 new SchoolClass { Nth = "Eighth" },
                 new SchoolClass { Nth = "Ninth" },
                 new SchoolClass { Nth = "Tenth" },
                 new SchoolClass { Nth = "Eleventh" }
           );
            modelBuilder.Entity<Grade>().HasData(
                new Grade { Letter = 'A', MinGrade = 91, MaxGrade = 100 },
                new Grade { Letter = 'B', MinGrade = 81, MaxGrade = 90 },
                new Grade { Letter = 'C', MinGrade = 71, MaxGrade = 80 },
                new Grade { Letter = 'D', MinGrade = 61, MaxGrade = 70 },
                new Grade { Letter = 'E', MinGrade = 51, MaxGrade = 60 },
                new Grade { Letter = 'F', MinGrade = 0, MaxGrade = 50 }
                );
            modelBuilder.Entity<Subject>().HasData(
            new Subject { Name = "AnaDili" },
            new Subject { Name = "Ədəbiyyat" },
            new Subject { Name = "Tarix" },
            new Subject { Name = "Rus_Dili" },
            new Subject { Name = "Ingilis_Dili" },
            new Subject { Name = "Fizika" },
            new Subject { Name = "Coğrayiya" },
            new Subject { Name = "Kimya" },
            new Subject { Name = "Cəbr" },
            new Subject { Name = "Həndəsə" }

         );


            modelBuilder.Entity<Worker>().HasMany(p => p.UserRoles)
              .WithOne().HasForeignKey(p => p.UserId).IsRequired();
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExofSt> ExofSts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}

//+ Fluent Api
//+Config DbContext Annatations