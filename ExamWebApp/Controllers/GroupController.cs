using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamWebApp.DAL;
using ExamWebApp.Models;
using ExamWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExamWebApp.Controllers
{
    [Authorize(Roles = "Admin,Member")]

    public class GroupController : Controller
    {
        private readonly ExamDbContext _db;
        public GroupController(ExamDbContext examDbContext)
        {
            _db = examDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Class = _db.SchoolClasses;
            ViewBag.Teacher = _db.Teachers;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Create(NewGroupViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            Group group = new Group()
            {
                GroupName = model.GroupName,
                TeacherId = model.TeacherId,
                SchoolClassId = model.SchoolClassId,
            };
            await _db.Groups.AddAsync(group);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index", "Examine");
        }
    }
}