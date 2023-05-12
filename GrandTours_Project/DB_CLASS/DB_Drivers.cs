using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTours_Project
{
    class DB_Drivers
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public DB_Drivers(string first_Name, string last_Name, int age, string address)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
            Age = age;
            Address = address;
        }
    }
}
