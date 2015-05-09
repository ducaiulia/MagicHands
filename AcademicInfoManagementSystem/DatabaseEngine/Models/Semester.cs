using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Semester
    {
        [Key]
        public int SID { get; set; }
        public string Name { get; set; }
        public List<Group> GroupList { get; set; }
        public List<Course> CourseList { get; set; }

        public Semester(int sid, string name)
        {
            //TODO Verify the unicity of the SID
            this.SID = sid;
            this.Name = name;
            this.GroupList = new List<Group>();
            this.CourseList= new List<Course>();
        }

        public void AddGroup(Group gr)
        {
            this.GroupList.Add(gr);
        }

        public void AddCourse(Course c)
        {
            this.CourseList.Add(c);
        }
    }
}
