using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class Faculty
    {
        private int FID { get; set; }
        private string name { get; set; }
        private List<Department> departments { get; set; }
        private List<Graduate> graduates { get; set; }
        private List<Undergraduate> undergraduates { get; set; }

        public Faculty(int fid,string name)
        {
            this.FID = fid;
            this.name = name;
            departments = new List<Department>();
            graduates = new List<Graduate>();
            undergraduates = new List<Undergraduate>();
        }


    }
}
