using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDBUSer.model
{
    public class User
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public User() : this("Dummy", "", "")
        { }
        public User(string username, string password, string role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }

        public override string ToString()
        {
            return $"{{{nameof(UserName)}={UserName}, {nameof(Password)}={Password}, {nameof(Role)}={Role}}}";
        }
    }

}
