using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Department
    {
        public int DID { get; set; }
        public string Name { get; set; }
        public ChiefOfDepartment Cod { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Department(int did, string name, ChiefOfDepartment cod)
        {
            this.DID = did;
            this.Name = name;
            this.Cod = cod;
            this.Teachers = new List<Teacher>();
        }
    }
}
