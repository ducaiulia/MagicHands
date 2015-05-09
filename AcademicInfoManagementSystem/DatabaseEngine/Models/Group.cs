using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Group
    {
        [Key]
        public int GRID { get; set; }
        public List<Student> StudentList { get; set; }

            public Group(int gid)
        {
            this.GRID = gid;
            StudentList = new List<Student>();
        }
    }
}
