using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Categories
    {
        public List<Category> CategoryList { get; set; }

        public Categories()
        {
            this.CategoryList = new List<Category>();
        }
    }
}
