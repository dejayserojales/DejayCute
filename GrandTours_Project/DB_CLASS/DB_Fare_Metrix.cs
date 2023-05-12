using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTours_Project
{
    class DB_Fare_Metrix
    {
        public string Destination_From { get; set; }
        public string Destination_To { get; set; }
        public double Fare_Price { get; set; }
        public DateTime Date_Updated { get; set; }

        public DB_Fare_Metrix(string destination_From, string destination_To, double fare_Price, DateTime date_Updated)
        {
            Destination_From = destination_From;
            Destination_To = destination_To;
            Fare_Price = fare_Price;
            Date_Updated = date_Updated;
        }
    }
}
