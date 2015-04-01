using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class OptionalCourse : Course
    {
        private Teacher Teacher { get; set; }
        public OptionalCourse(int Cid, string Name, Teacher teacher)
            : base(Cid, Name)
        {
            this.Teacher = teacher;
        }
    }
}
