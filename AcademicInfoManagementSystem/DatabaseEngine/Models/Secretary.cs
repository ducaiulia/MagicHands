using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{

    public class Secretary : User
    {
        //public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        GrantsTemplate GrantsTemplate { get; set; }

        public Secretary(int sid, string firstName, string lastName, string account, string password)
            : base(account, password)
        {
            //this.ID = sid;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GrantsTemplate = null;
        }

        public void AddGrantsTemplate(int total,int performanceGrant, int meritGrant,int  studyGrant, int socialGrant)
        {
            this.GrantsTemplate = new GrantsTemplate(total,performanceGrant, meritGrant, studyGrant, socialGrant);
        }


    }
}
