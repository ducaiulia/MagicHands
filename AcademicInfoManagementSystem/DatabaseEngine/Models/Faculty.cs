using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Faculty
    {
        [Key]
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

        public void AddDepartment(Department dep)
        {
            this.DepartmentList.Add(dep);
        }

        public void AddGraduate(Graduate grd)
        {
            this.GraduateList.Add(grd);
        }

        public void AddUndergraduate(Undergraduate undgrd)
        {
            this.UndergraduateList.Add(undgrd);
        }
    }
}
