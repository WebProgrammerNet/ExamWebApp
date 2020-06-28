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

namespace ExamWebApp.Controllers
{
    [Authorize(Roles = "Admin,Member")]
    public class ExamineController : Controller
    {
        private readonly ExamDbContext _db;

        public ExamineController(ExamDbContext examDbContext)
        {
            _db = examDbContext;
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
        public async Task<IActionResult> Create(NewExamViewModel newExam)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            Subject subject = await _db.Subjects.FirstOrDefaultAsync(t => t.SubjectId == newExam.SubjectId);
            

            Exam exam = new Exam()
            {
              ExamDay = newExam.ExamDay,
               SubjectId = subject.SubjectId
            };
            await _db.Exams.AddAsync(exam);
            await _db.SaveChangesAsync();


            return RedirectToAction("Index", "Examine");
        }

    }
}