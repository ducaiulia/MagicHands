using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Undergraduate
    {
        private List<StudyProgramme> StudyProgList;

        public Undergraduate()
        {
            this.StudyProgList = new List<StudyProgramme>();
        }
    }
}
