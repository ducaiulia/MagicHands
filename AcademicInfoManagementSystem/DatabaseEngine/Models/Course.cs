using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Course
    {
        public int Cid { get; set; }
        public string Name { get; set; }
        public Semester Semester { get; set; }
        public Exam Exam { get; set; }

        public Course(int cid, string name, Semester semester, Exam exam)
        {
            this.Cid = cid;
            this.Name = name;
            this.Semester = semester;
            this.Exam = exam;
        }
    }
}
