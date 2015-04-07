using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class StudentExamGrade
    {
        public Student Student { get; set; }
        public int Grade { get; private set; } //only twice modifiable constraint
        public Exam Exam { get; set; }

        public StudentExamGrade(Student student, int grade, Exam exam)
        {
            this.Student = student;
            this.Grade = grade;
            this.Exam = exam;
        }


    }
}
