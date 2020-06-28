using ExamWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.ViewModels
{
    public class NewExamViewModel
    {
        public DateTime ExamDay { get; set; }
        public string SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
