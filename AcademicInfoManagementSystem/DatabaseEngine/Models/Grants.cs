using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Grants
    {
        public List<Student> PerformanceGrantlList { get; set; }
        public List<Student> MeritGrantlList { get; set; }
        public List<Student> StudyGrantList { get; set; }
        public List<Student> SocialGrantList { get; set; }

        public Grants()
        {
            this.PerformanceGrantlList = new List<Student>();
            this.MeritGrantlList = new List<Student>();
            this.StudyGrantList = new List<Student>();
            this.SocialGrantList = new List<Student>();
        }

    }
}
