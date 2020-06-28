using ExamWebApp.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.ViewModels
{
    public class NewTeacherViewModel
    {
        [Required(ErrorMessage = "Required"), StringLength(150, ErrorMessage = "Length can't be more than 150")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(150, ErrorMessage = "Length can't be more than 150")]
        public string Surname { get; set; }
        public string SubjectId { get; set; }
        public Subject Subject { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Required")]
        public IFormFile StudentPhoto { get; set; }

        [NotMapped]
        public IFormFile ChangePhoto { get; set; }
    }
}
