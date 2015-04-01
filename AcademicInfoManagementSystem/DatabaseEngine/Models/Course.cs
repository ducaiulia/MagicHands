using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Course
    {
        private int Cid { get; set; }
        private string Name { get; set; }
        //private Semester Semester { get; set; }
        //private Exam Exam { get; set; }

        public Course(int Cid, string Name)
        {
            this.Cid = Cid;
            this.Name = Name;
        }
    }
}
