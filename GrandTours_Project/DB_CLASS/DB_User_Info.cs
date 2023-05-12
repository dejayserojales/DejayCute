using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTours_Project
{
    class DB_User_Info
    {
        public int user_id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public int Account_ID { get; set; }

       public int Role_ID { get; set; }

        public DB_User_Info(int user_id, string first_Name, string last_Name, int age, string address, int account_ID, int role_ID)
        {
            this.user_id = user_id;
            First_Name = first_Name;
            Last_Name = last_Name;
            Age = age;
            Address = address;
            Account_ID = account_ID;
            Role_ID = role_ID;
        }
    }
}
