using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    class Grants
    {

        private List<Student> performGrant { get; set; }
        private List<Student> meritGrant { get; set; }
        private List<Student> studyGrant { get; set; }
        private List<Student> socialGrant { get; set; }

        public Grants()
        {
            performGrant = new List<Student>();
            meritGrant = new List<Student>();
            studyGrant = new List<Student>();
            socialGrant = new List<Student>();
        }

    }
}
