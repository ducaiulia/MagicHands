using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class GrantsTemplate
    {
        [Key]
        public int GTID { get; private set; } // auto generated id
        public int Total { get; set; }
        public int PerformanceGrant { get; set; }
        public int MeritGrant { get; set; }
        public int StudyGrant { get; set; }
        public int SocialGrant { get; set; }
        public Grants Grants { get; set; }
        [NotMapped]
        private static int Counter = 0;

        public GrantsTemplate(int total,int performanceGrant,int meritGrant,int studyGrant,int socialGrant)
        {
            this.Total = total;
            this.PerformanceGrant= performanceGrant;
            this.MeritGrant = meritGrant;
            this.StudyGrant = studyGrant;
            this.SocialGrant = socialGrant;
            this.Grants = new Grants();
            this.GTID = System.Threading.Interlocked.Increment(ref Counter);
        }
    }
}
