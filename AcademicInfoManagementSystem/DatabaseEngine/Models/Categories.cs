using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class Categories
    {
        private List<Category> categoryList { get; set; }

        public Categories()
        {
            categoryList = new List<Category>();
        }
    }
}
