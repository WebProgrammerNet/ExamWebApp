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

    public class StudentController : Controller
    {
        private readonly ExamDbContext _db;
        private IWebHostEnvironment _env;
        public StudentController(ExamDbContext examDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _db = examDbContext;
            _env = webHostEnvironment;
        }
        public IActionResult Index()
        {
            IEnumerable<Student> students = _db.Students;
            return View(students);
        }
        public async Task<IActionResult> Detail(string id)
        {

            if (id == null) return NotFound();
            Student student = await _db.Students.FirstOrDefaultAsync(x => x.StudentId == id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Group = _db.Groups;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewStudentViewModel newStudent)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            Group group = await _db.Groups.FirstOrDefaultAsync(r => r.GroupId == newStudent.GroupId);
            Student student = new Student()
            {
                Name = newStudent.Name,
                Surname = newStudent.Surname,
                GroupId  = group.GroupId,
                Mark = null
            };

            if (!newStudent.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "You can chose only image format");
                return View();
            }
            if (!newStudent.Photo.CheckSize(2))
            {
                ModelState.AddModelError("Photo", "You can chose only small 1 MB");
                return View();
            }
            string createdImage = await newStudent.Photo.CopyImage(_env.WebRootPath, "student");
            student.ImagePath = createdImage;

            await _db.Students.AddAsync(student);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", "Examine");
        }


    }
}