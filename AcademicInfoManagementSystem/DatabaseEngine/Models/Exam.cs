using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Exam
    {
        public int EID { get; set; }
        private Teacher secondTeacher = null; //default null
        public Course Course;
        public List<StudentExamGrade> StudentExamGrades { get; set; }
        public Teacher SecondTeacher { get; set; }

        public Exam(int eid, Course course)
        {
            this.EID = eid;
            this.Course = course;
            this.StudentExamGrades = new List<StudentExamGrade>();
        }

    }
}
