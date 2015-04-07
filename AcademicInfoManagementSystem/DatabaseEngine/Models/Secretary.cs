using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{

    

    class Secretary :User
    {
        private int SID { get; set; }
        private string name { get; set; }
        GrantsTemplate grants { get; set; }

        public Secretary(int sid,string name, string account,string password,GrantsTemplate grants) : base(account,password)
        {
            this.SID = sid;
            this.name = name;
            this.grants = grants;
        }
    }
}
