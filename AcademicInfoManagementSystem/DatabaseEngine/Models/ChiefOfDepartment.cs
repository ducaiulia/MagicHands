using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class ChiefOfDepartment : Teacher
    {
        public ChiefOfDepartment(int Tid, string Name)
            : base(Tid, Name)
        {
        }

    }

}