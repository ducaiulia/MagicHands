using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Teacher : User
    {
        public int TID { get; set; }
        public string Name { get; set; }
        public List<Course> CourseList;

        public Teacher(string username, string password, int tid, string name)
            : base(username, password)
        {
            this.TID = tid;
            this.Name = Name;
            this.CourseList = new List<Course>();
        }
    }
}
