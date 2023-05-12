using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTours_Project
{
    class DB_Passenger
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public double Fare_Price { get; set; }
        public double Cash_Received { get; set; }
        public double Cash_Change { get; set; }

        public int Seat_Number { get; set; }

        public DB_Passenger(string first_Name, string last_Name, double fare_Price, double cash_Received, double cash_Change, int seat_Number)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
            Fare_Price = fare_Price;
            Cash_Received = cash_Received;
            Cash_Change = cash_Change;
            Seat_Number = seat_Number;
        }
    }
}
