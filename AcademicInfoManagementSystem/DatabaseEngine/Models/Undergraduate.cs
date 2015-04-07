using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class Undergraduate
    {
        private List<StudyProgramme> stproglist { get; set; }

        public Undergraduate()
        {
            stproglist = new List<StudyProgramme>();
        }
    }
}
