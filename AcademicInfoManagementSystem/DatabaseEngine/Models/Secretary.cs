using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{

    public class Secretary : User
    {
        public int SID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        GrantsTemplate GrantsTemplate { get; set; }

        public Secretary(int sid, string firstName, string lastName, string account, string password, GrantsTemplate grants)
            : base(account, password)
        {
            this.SID = sid;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GrantsTemplate = grants;
        }
    }
}
