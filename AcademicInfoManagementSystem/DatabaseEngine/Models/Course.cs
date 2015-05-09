using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Course
    {
        [Key]
        public int CID { get; set; }
        public string Name { get; set; }
        public Semester Semester { get; set; }
        public Exam Exam { get; set; }

        public Course(int cid, string name, Semester semester, Exam exam)
        {
            this.CID = cid;
            this.Name = name;
            this.Semester = semester;
            this.Exam = exam;
        }


    }
}
