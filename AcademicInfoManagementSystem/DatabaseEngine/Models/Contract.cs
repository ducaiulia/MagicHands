using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Contract
    {
        public Student Student { get; set; }
        public List<Course> CourseList { get; set; }

        public Contract(Student student)
        {
            this.Student = student;
            this.CourseList = new List<Course>();
        }
    }
}
