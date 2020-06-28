using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.Models
{
    public class Worker : IdentityUser
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Required"), StringLength(150, ErrorMessage = "Length can't be more than 150")]
        public string Surname { get; set; }
        public string Password { get; set; }
        public bool Deleted { get; set; }
        public ICollection<IdentityUserRole<string>> UserRoles { get; set; }

    }
}
