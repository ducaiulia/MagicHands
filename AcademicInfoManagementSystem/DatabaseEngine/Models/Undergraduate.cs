using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Undergraduate
    {
        private int ID;
        private List<StudyProgramme> StudyProgList;

        public Undergraduate()
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
