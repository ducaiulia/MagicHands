using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Grants
    {
        public int GID { get; private set; } // auto generated id
        public List<Student> PerformanceGrantList { get; set; }
        public List<Student> MeritGrantlList { get; set; }
        public List<Student> StudyGrantList { get; set; }
        public List<Student> SocialGrantList { get; set; }
        [NotMapped]
        private static int Counter = 0;

        public Grants()
        {
            this.PerformanceGrantList = new List<Student>();
            this.MeritGrantlList = new List<Student>();
            this.StudyGrantList = new List<Student>();
            this.SocialGrantList = new List<Student>();
            this.GID = System.Threading.Interlocked.Increment(ref Counter);
        }

    }
}
