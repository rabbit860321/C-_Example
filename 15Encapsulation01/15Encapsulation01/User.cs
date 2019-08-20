using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Encapsulation01
{
    class User
    {
        private string Username;
        private string password;

        public User(string username,string password)
        {
            this.Username = username;
            this.password = password;
        }
        public string getUsername()
        {
            return Username;
        }

        public bool comparePassword(String targetPassword)
        {
            if (this.password == targetPassword)
                return true;
            else
                return false;
        }
    }
}
