using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ExamWebApp.Models
{
    public class Grade
    {
        public Grade()
        {
            GradeId = Guid.NewGuid().ToString();
        }
        public string GradeId { get; set; }
        [Required]
        public char Letter { get; set; } 
        [Required]
        public byte MinGrade { get; set; }
        [Required]
        public byte MaxGrade { get; set; }

    }
}
