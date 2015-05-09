using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    [ComplexType]
    public class Contract
    {
        [Key]
        public int CTID { get; private set; } // auto generated id
        public Student Student { get; set; }
        public List<Course> CourseList { get; set; }
        [NotMapped]
        private static int Counter = 0;

        public Contract(Student student)
        {
            this.Student = student;
            this.CourseList = new List<Course>();
            this.CTID = System.Threading.Interlocked.Increment(ref Counter);
        }
    }
}
