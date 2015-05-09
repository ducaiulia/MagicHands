using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Student : User
    {
        public int CurrentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Contract> ContractList { get; set; }
        //public List<StudentExamGrade> GradesList { get; set; }
        public List<int> SemesterAverage { get; set; }
        [NotMapped]
        private static int Counter = 0;


        public Student(int sid, string firstName, string lastName, string username, string password)
            : base(username, password)
        {
            //this.ID = sid;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ContractList = new List<Contract>();
            //this.GradesList = new List<StudentExamGrade>();
            this.SemesterAverage = new List<int>();
            this.CurrentID = System.Threading.Interlocked.Increment(ref Counter);

        }
    }
}
