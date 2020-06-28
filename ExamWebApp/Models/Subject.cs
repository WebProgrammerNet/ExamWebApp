using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.Models
{
    public class Subject
    {
        public Subject()
        {
            SubjectId = Guid.NewGuid().ToString();
        }

        public string SubjectId { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(100, ErrorMessage = "Length can't be more than 100")]
        public string Name { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
