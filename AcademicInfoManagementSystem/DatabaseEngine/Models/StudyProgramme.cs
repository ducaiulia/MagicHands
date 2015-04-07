using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class StudyProgramme
    {
        private int STPID { get; set; }
        private List<StudyLanguage> stlanglist { get; set; }

        public StudyProgramme(int stpid)
        {
            this.STPID = stpid;
            stlanglist = new List<StudyLanguage>();
        }
        


    }
}
