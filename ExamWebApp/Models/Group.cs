using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.Models
{
    public class Group
    {
        public Group()
        {
            GroupId = Guid.NewGuid().ToString();
        }
        public string GroupId { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(10, ErrorMessage = "Length can't be more than 10")]
        public string GroupName { get; set; }

        public string SchoolClassId { get; set; }
        public SchoolClass SchoolClass { get; set; }

        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
