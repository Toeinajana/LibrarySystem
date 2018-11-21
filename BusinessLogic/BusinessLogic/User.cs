using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class User
    {
        public int UID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserLevel { get; set; }
        public string UserEmail { get; set; }

        public User(int uid, string UserName, string Password, int UserLevel, string UserEmail)
        {
            this.UID = UID;
            this.UserName = UserName;
            this.Password = Password;
            this.UserLevel = UserLevel;
            this.UserEmail = UserEmail;

        }
    }
}
