using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Group
    {
        public int GID { get; set; }
        public List<Student> StudentList { get; set; }

            public Group(int gid)
        {
            this.GID = gid;
            StudentList = new List<Student>();
        }
    }
}
