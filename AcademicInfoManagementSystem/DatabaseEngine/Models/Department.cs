using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class Department
    {
        [Key]
        public int DID { get; set; }
        public string Name { get; set; }
        public ChiefOfDepartment Cod { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Department(int did, string name)
        {
            this.DID = did;
            this.Name = name;
            //this.Cod = cod;
            this.Teachers = new List<Teacher>();
        }

        public void AddCod(ChiefOfDepartment cod)
        {
            this.Cod = cod;
        }

        public void AddTeacher(Teacher t)
        {
            this.Teachers.Add(t);
        }
    }
}
