using ExamWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.ViewModels
{
    public class NewGroupViewModel
    {
        public string GroupName { get; set; }

        public string SchoolClassId { get; set; }
        public SchoolClass SchoolClass { get; set; }

        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
