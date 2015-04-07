using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Graduate
    {
        public List<StudyProgramme> StudyProgList { get; set; }

        public Graduate()
        {
            this.StudyProgList = new List<StudyProgramme>();
        }
    }
}
