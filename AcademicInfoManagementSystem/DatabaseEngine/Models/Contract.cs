using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Contract
    {
        private Student student { get; set; }
        private List<Course> studentsCourses { get; set; }

        public Contract(Student st)
        {
            this.student = st;
            studentsCourses = new List<Course>();
        }
    }
}
