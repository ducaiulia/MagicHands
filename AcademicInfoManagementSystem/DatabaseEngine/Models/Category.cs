using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Category
    {
        public int ID { get; private set; } 
        public List<OptionalCourse> OptionalCourseList { get; set; }
        private static int Counter = 0;

        public Category()
        {
            this.OptionalCourseList = new List<OptionalCourse>();
            this.ID = System.Threading.Interlocked.Increment(ref Counter);
        }
    }
}
