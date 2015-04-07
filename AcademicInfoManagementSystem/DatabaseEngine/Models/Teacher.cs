using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Teacher :User
    {
        private int Tid { get; set; }
        private string Name { get; set; }
        private List<Course> courselist { get; set; }

        public Teacher(string account,string password,int Tid, string Name) : base (account,password)
        {
            this.Tid = Tid;
            this.Name = Name;
            courselist = new List<Course>();
        }
    }
}
