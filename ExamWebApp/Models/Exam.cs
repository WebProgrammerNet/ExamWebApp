using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.Models
{
    public class Exam
    {
        public Exam()
        {
            ExamId = Guid.NewGuid().ToString();
        }
        public string ExamId { get; set; }
        [Required]
        public DateTime ExamDay { get; set; }
        public string SubjectId { get; set; }
        public Subject Subject { get; set; }

        public virtual ICollection<ExofSt> ExofSts { get; set; }
    }
}
