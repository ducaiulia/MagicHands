using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class ChiefOfDepartment : Teacher
    {
        public Department Department { get; set; }

        public ChiefOfDepartment(int tid, string name, string username, string password, Department department)
            : base(username, password, tid, name)
        {
            this.Department = department;
        }

    }

}