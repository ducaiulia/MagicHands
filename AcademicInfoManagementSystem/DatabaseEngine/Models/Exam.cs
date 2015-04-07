using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Exam
    {
        private int EID { get; set; }
        private Teacher secondTeacher { get; set; } //default null
        List<StudentExamGrade> seg { get; set; }

        public Exam(int eid,Teacher second)
        {
            this.EID = eid;
            this.secondTeacher = second;
            seg = new List<StudentExamGrade>();
        }

    }
}
