using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class Group
    {
        private int GID { get; set; }
        private List<Student> studentlist { get; set; }

            public Group(int gid)
        {
            this.GID = gid;
            studentlist = new List<Student>();
        }
    }
}
