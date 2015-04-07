using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class StudentExamGrade
    {
        Student student { get; set; }
        int grade { get; set; }
        Exam exam { get; set; }

        public StudentExamGrade(Student student,int grade,Exam exam)
        {
            this.student = student;
            this.grade = grade;
            this.exam = exam;
        }


    }
}
