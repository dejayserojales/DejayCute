using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTours_Project
{
    class DB_Reservation
    {
        public DateTime Date_Reservation { get; set; }
        public DateTime Departure_Date { get; set; }
        public DateTime Departure_Time { get; set; }
        public string Destination { get; set; }

        public DB_Reservation(DateTime date_Reservation, DateTime departure_Date, DateTime departure_Time, string destination)
        {
            Date_Reservation = date_Reservation;
            Departure_Date = departure_Date;
            Departure_Time = departure_Time;
            Destination = destination;
        }
        //public int Van_ID { get; set; }
        //public int Fare_Metrix_ID { get; set; }


    }
}
