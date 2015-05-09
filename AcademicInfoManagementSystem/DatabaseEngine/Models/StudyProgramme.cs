using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class StudyProgramme
    {
        [Key]
        public int STPID { get; set; }
        public List<StudyLanguage> StudyLangList;

        public StudyProgramme(int stpid)
        {
            this.STPID = stpid;
            this.StudyLangList = new List<StudyLanguage>();
        }

        public void AddStudyLanguage(StudyLanguage sl)
        {
            this.StudyLangList.Add(sl);
        }



    }
}
