using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Teacher
    {
        int Tid { get; set; }
        private string Name { get; set; }
        private List<Course> Courses { get; set; }

        public Teacher(int Tid, string Name)
        {
            this.Tid = Tid;
            this.Name = Name;
        }
    }
}
