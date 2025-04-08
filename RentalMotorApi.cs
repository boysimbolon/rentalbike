using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBike
{
        public class RentalMotorApi
        {
            public IList<Rentals> DataBooking { get; set; }
            public IList<Motors> Motor { get; set; }
        }
        public class Rentals
        {
            public int id { get; set; }
            public string rental_name { get; set; }
            public string rental_email { get; set; }
            public string rental_phone { get; set; }
            public string rental_date { get; set; }
            public string rental_time { get; set; }
            public int motor_id { get; set; }
            public string booking_status { get; set; }
        }

        public class Motors
        {
            public int id { get; set; }
            public string product_name { get; set; }
            public string product_description { get; set; }
            public string product_price { get; set; }
            public string product_image { get; set; }
        }

        public class Root
        {
            public Rentals rental { get; set; }
            public Motors motor { get; set; }
        }
}
