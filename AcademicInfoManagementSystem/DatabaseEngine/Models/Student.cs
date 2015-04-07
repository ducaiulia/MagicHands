using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Student
    {
        private int Sid { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private List<Contract> contractlist { get; set; }
        private List<StudentExamGrade> gradesList { get; set; }
        private List<int> semesteraverage { get; set; }
        //private LoginCredentials LoginCreds
        //{
        //    get { return LoginCreds; }
        //}
        public Student(int sid, string firstName, string lastName)
        {
            this.Sid = sid;
            this.FirstName = firstName;
            this.LastName = lastName;
            contractlist = new List<Contract>();
            gradesList = new List<StudentExamGrade>();
            semesteraverage = new List<int>();

        }
    }
}
