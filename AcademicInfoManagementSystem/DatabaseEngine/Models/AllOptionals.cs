using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class AllOptionals
    {
        private int ID = 1;
        public List<OptionalCourse> OptionalCourseList{ get; set; }

        public AllOptionals()
        {
            this.OptionalCourseList = new List<OptionalCourse>();
        }


    }
}
