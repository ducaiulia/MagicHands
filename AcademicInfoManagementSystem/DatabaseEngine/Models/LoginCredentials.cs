using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Models
{
    public class LoginCredentials
    {
        private string Username { get; set; }
        private string Password { get; set; }

        public LoginCredentials(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}