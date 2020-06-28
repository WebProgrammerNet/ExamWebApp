using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamWebApp.DAL;
using ExamWebApp.Models;
using ExamWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace ExamWebApp.Controllers
{
    [Authorize(Roles = "Admin,Member")]

    public class ExamItemController : Controller
    {
        private readonly ExamDbContext _db;
        public ExamItemController(ExamDbContext exam)
        {
            _db = exam;
        }

        public IActionResult Index()
        {
            IEnumerable<ExofSt> model = _db.ExofSts.Include(r => r.Exam).Include(t => t.Student).Include(y => y.Teacher);
            return View(model);
        }

        public IActionResult Create()
        {
            ViewBag.Exam = _db.Exams;
            ViewBag.Student = _db.Students;
            ViewBag.Teacher = _db.Teachers;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewExOfStudentVM newExamine)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            Exam exam = await _db.Exams.FirstOrDefaultAsync(t => t.ExamId == newExamine.ExamId);
            Student student = await _db.Students.FirstOrDefaultAsync(t => t.StudentId == newExamine.StudentId);
            Teacher teacher = await _db.Teachers.FirstOrDefaultAsync(t => t.TeacherId == newExamine.TeacherId);
          
            ExofSt exof = new ExofSt()
            {
                ExamId = exam.ExamId,
                StudentId = student.StudentId,
                TeacherId = teacher.TeacherId
            };
            await _db.ExofSts.AddAsync(exof);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index", "Examine");
        }

    }
}