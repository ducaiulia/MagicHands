using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class StudyLanguage
    {
        public int STLID { get; set; }
        public Secretary Secretary { get; set; }
        private List<Semester> SemesterList;

            public StudyLanguage(int stlid,Secretary secretary)
        {
            this.STLID = stlid;
            this.Secretary = secretary;
            this.SemesterList = new List<Semester>();
        }
    }
}
