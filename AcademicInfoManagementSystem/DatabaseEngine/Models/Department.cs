using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Department
    {
        private int DID { get; set; }
        private string name { get; set; }
        ChiefOfDepartment cod { get; set; }
        List<Teacher> teachers { get; set; }

        public Department(int did,string name,ChiefOfDepartment cod)
        {
            this.DID = did;
            this.name = name;
            this.cod = cod;
            teachers = new List<Teacher>();
        }
    }
}
