using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Faculty
    {
        public int FID { get; set; }
        public string Name { get; set; }
        public List<Department> DepartmentList { get; set; }
        public List<Graduate> GraduateList { get; set; }
        public List<Undergraduate> UndergraduateList { get; set; }

        public Faculty(int fid, string name)
        {
            this.FID = fid;
            this.Name = name;
            this.DepartmentList = new List<Department>();
            this.GraduateList = new List<Graduate>();
            this.UndergraduateList = new List<Undergraduate>();
        }


    }
}
