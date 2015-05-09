using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Categories
    {
        private int ID = 1;
        public List<Category> CategoryList { get; set; }

        public Categories()
        {
            this.CategoryList = new List<Category>();
        }
    }
}
