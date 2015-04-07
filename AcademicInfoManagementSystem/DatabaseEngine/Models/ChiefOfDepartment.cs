using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class ChiefOfDepartment : Teacher
    {
        public Department department { get; set; }

        public ChiefOfDepartment(int Tid, string Name,string account,string password,Department dep)
            : base(account,password,Tid,Name)
        {
            this.department = dep;
        }

    }

}