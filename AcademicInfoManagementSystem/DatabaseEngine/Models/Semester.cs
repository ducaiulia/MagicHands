using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class Semester
    {
        private int SID { get; set; }
        private string semester { get; set; }
        List<Group> grouplist { get; set; }
        List<Course> courselist { get; set; }

        public Semester(int sid, string semester)
        {
            this.SID = sid;
            this.semester = semester;
            grouplist = new List<Group>();
            courselist = new List<Course>();

        }
    }
}
