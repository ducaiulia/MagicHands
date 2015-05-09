using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Student : User
    {
        private static int currentId;
        //public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Contract> ContractList { get; set; }
        //public List<StudentExamGrade> GradesList { get; set; }
        public List<int> SemesterAverage { get; set; }

        public Student(int sid, string firstName, string lastName, string username, string password)
            : base(username, password)
        {
            //this.ID = sid;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ContractList = new List<Contract>();
            //this.GradesList = new List<StudentExamGrade>();
            this.SemesterAverage = new List<int>();

        }

        public static int CurrentId
        {
            get { return currentId; }
            set { currentId = value; }
        }
    }
}
