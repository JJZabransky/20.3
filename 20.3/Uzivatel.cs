using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._3
{
    public class Uzivatel
    {
        private string username;
        private string password;
        public enum access
        {
            USER,ADMIN,EMPLOYEE
        }

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }

        public Uzivatel(string username, string password, access a)
        {
            this.username = username;
            this.password = password;
        }
    }
}
