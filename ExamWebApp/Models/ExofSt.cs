using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWebApp.Models
{
    public class ExofSt
    {
        public ExofSt()
        {
            ExofStId = Guid.NewGuid().ToString();
        }
        public string ExofStId { get; set; }

        public string StudentId { get; set; }
        public Student Student { get; set; }

        public string ExamId { get; set; }
        public Exam Exam { get; set; }

        public string TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}
