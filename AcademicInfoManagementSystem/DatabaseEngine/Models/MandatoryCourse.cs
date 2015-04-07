using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class MandatoryCourse : Course
    {
        private Teacher Teacher { get; set; }
        public MandatoryCourse(int Cid, string Name, Teacher teacher,Semester semester,Exam exam)
            : base(Cid, Name,semester,exam)
        {
            this.Teacher = teacher;
        }
    }
}
