using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class StudyLanguage
    {
        private int STLID { get; set; }
        private List<Semester> semesterlist { get; set; }
        Secretary secretary { get; set; }

            public StudyLanguage(int stlid,Secretary secretary)
        {
            this.STLID = stlid;
            this.secretary = secretary;
            semesterlist = new List<Semester>();
        }
    }
}
