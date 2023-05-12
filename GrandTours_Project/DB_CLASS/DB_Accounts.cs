using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTours_Project
{
    class DB_Accounts
    {
        public int account_id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int role_id { get; set; }

        public DB_Accounts(int account_id, string username, string password, string status, int role_id)
        {
            this.account_id = account_id;
            Username = username;
            Password = password;
            Status = status;
            this.role_id = role_id;
        }
    }
}
