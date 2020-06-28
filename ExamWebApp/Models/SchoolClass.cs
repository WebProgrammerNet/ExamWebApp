using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.Models
{
    public class SchoolClass
    {
        public SchoolClass()
        {
            SchoolClassId = Guid.NewGuid().ToString();
        }
        public string SchoolClassId { get; set; }
        [Required]
        public string Nth { get; set; }

        public virtual ICollection<Group> Groups{ get; set; }
    }
}
