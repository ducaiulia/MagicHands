using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Graduate
    {
        private int ID;
        public List<StudyProgramme> StudyProgList { get; set; }

        public Graduate()
        {
            this.ID = 1;
            this.StudyProgList = new List<StudyProgramme>();
        }

        public void AddStudyProgramme(StudyProgramme sp)
        {
            this.StudyProgList.Add(sp);
        }
    }
}
