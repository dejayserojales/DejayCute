using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTours_Project
{
    class DB_Van_List
    {
        public string Plate_Number { get; set; }
        public int capacity { get; set; }

        public DB_Van_List(string plate_Number, int capacity)
        {
            Plate_Number = plate_Number;
            this.capacity = capacity;
        }
    }
}
