using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.Models
{
    public class Student
    {
        public Student()
        {
            StudentId = Guid.NewGuid().ToString();
            Number = (ushort)new Random().Next(1, 65530);
        }
        public string StudentId { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(150, ErrorMessage = "Length can't be more than 150")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(150, ErrorMessage = "Length can't be more than 150")]
        public string Surname { get; set; }
        public ushort Number { get; set; }
        public byte? Mark { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string ImagePath { get; set; }
        public string GroupId { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<ExofSt> ExofSts { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Required")]
        public IFormFile Photo { get; set; }

        [NotMapped]
        public IFormFile ChangePhoto { get; set; }
    }
}
