using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Category
    {
        public List<OptionalCourse> OptionalCourseList { get; set; }

        public Category()
        {
            this.OptionalCourseList = new List<OptionalCourse>();
        }
    }
}
