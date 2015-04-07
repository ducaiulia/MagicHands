using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class GrantsTemplate
    {
        private int total { get; set; }
        private int performGrant { get; set; }
        private int meritGrant { get; set; }
        private int studyGrant { get; set; }
        private int socialGrant { get; set; }

        public GrantsTemplate(int total,int perform,int merit,int study,int social)
        {
            this.total = total;
            this.performGrant = perform;
            this.meritGrant = merit;
            this.studyGrant = study;
            this.socialGrant = social;
        }
    }
}
