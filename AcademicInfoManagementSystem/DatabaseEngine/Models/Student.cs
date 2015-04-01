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
        //private LoginCredentials LoginCreds
        //{
        //    get { return LoginCreds; }
        //}
        public Student(int sid, string firstName, string lastName)
        {
            this.Sid = sid;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
