using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class MandatoryCourse : Course
    {
        public Teacher Teacher { get; set; }

        public MandatoryCourse(int cid, string name, Teacher teacher,Semester semester,Exam exam)
            : base(cid, name,semester,exam)
        {
            this.Teacher = teacher;
        }
    }
}
