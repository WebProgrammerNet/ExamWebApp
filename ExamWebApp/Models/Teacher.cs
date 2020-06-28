using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.Models
{
    public class Teacher
    {
        public Teacher()
        {
            TeacherId = Guid.NewGuid().ToString();
        }
        public string TeacherId { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(150, ErrorMessage = "Length can't be more than 150")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(150, ErrorMessage = "Length can't be more than 150")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string ImagePath { get; set; }
        public string SubjectId { get; set; }
        public Subject Subject { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<ExofSt> ExofSts { get; set; }
    }
}
