using ExamWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.ViewModels
{
    public class ExamItemViewModel
    {
        public IEnumerable<ExofSt> ExofSts { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable <Group> Groups { get; set; }
    }
}
