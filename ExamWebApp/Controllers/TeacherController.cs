using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamWebApp.DAL;
using ExamWebApp.Models;
using ExamWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using RemindWebApp.Extension_GenerateImage;

namespace ExamWebApp.Controllers
{
    [Authorize(Roles = "Admin,Member")]

    public class TeacherController : Controller
    {
        private readonly ExamDbContext _db;
        private IWebHostEnvironment _env;
        public TeacherController(ExamDbContext examDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _db = examDbContext;
            _env = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            ViewBag.Subject = _db.Subjects;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewTeacherViewModel newteacher)
        {
            if (!ModelState.IsValid)
            {
                return View(newteacher);
            }
          
            if (newteacher.StudentPhoto.ContentType.Contains(@"image/"))
            {
                Subject subject = await _db.Subjects.FirstOrDefaultAsync(r => r.SubjectId == newteacher.SubjectId);
                Teacher teacher = new Teacher()
                {
                    Name = newteacher.Name,
                    Surname = newteacher.Surname,
                    SubjectId = subject.SubjectId
                };

                if (!newteacher.StudentPhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "You can chose only image format");
                    return View();
                }
                if (!newteacher.StudentPhoto.CheckSize(2))
                {
                    ModelState.AddModelError("Photo", "You can chose only small 1 MB");
                    return View();
                }
                string createdImage = await newteacher.StudentPhoto.CopyImage(_env.WebRootPath, "teacher");
                teacher.ImagePath = createdImage;

                await _db.Teachers.AddAsync(teacher);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Examine");
        }

    }
}