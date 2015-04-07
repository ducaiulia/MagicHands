using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class Category
    {
        private List<OptionalCourse> optionalList { get; set; }

        public Category()
        {
            optionalList = new List<OptionalCourse>();
        }
    }
}
