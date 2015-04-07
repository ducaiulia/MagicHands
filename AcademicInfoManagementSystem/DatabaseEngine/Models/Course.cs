using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Course
    {
        private int Cid { get; set; }
        private string Name { get; set; }
        private Semester semester { get; set; }
        private Exam exam { get; set; }

        public Course(int Cid, string Name,Semester semester,Exam exam)
        {
            this.Cid = Cid;
            this.Name = Name;
            this.semester = semester;
            this.exam = exam;
        }
    }
}
