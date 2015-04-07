using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class GrantsTemplate
    {
        public int Total { get; set; }
        public int PerformanceGrant { get; set; }
        public int MeritGrant { get; set; }
        public int StudyGrant { get; set; }
        public int SocialGrant { get; set; }

        public GrantsTemplate(int total,int performanceGrant,int meritGrant,int studyGrant,int socialGrant)
        {
            this.Total = total;
            this.PerformanceGrant= performanceGrant;
            this.MeritGrant = meritGrant;
            this.StudyGrant = studyGrant;
            this.SocialGrant = socialGrant;
        }
    }
}
