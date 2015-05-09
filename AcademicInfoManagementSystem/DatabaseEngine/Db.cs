using System.Collections.Generic;
using DatabaseEngine.Models;

namespace DatabaseEngine
{
    public static class Db
    {
        private static List<Student> students = new List<Student>()
        {
            new Student(1, "George", "Popescu", "gpie10023", "asasfasf"), 
            new Student(2, "Ana", "Ionescu", "aiie10024", "1234567")
        };

        private static List<Exam> exams = new List<Exam>()
        {
            //new Exam(10, new Course(3, "AI", new Semester(4, "Semester 4 Year 2"), ))
            //wrong implementation of exam and course contructors. They are dependent
        };

        public static List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public static List<Exam> Exams
        {
            get { return exams; }
            set { exams = value; }
        }
    }
}
