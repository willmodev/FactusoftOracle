using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Administrator
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PasswordEmail { get; set; }

        public Administrator()
        {

        }
        public Administrator(string user, string password)
        {
            User = user;
            Password = password;
            Email = string.Empty;
            PasswordEmail = string.Empty;
        }

    }
}
