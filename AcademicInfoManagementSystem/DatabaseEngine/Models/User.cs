using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class User
    {
        
        private string account { get; set; }
        private string password { get; set; }

        public User(string acc,string pass)
        {
           
            this.account = acc;
            this.password = pass;
        }
    }
}
