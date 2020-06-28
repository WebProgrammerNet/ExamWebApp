using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamWebApp.ViewModels
{
    public class NewStudentViewModel
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(150, ErrorMessage = "Length can't be more than 150")]
        public string Surname { get; set; }
        public string ImagePath { get; set; }
        public string GroupId { get; set; }
        public virtual Group Group { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Required")]
        public IFormFile Photo { get; set; }

        [NotMapped]
        public IFormFile ChangePhoto { get; set; }
    }
}
