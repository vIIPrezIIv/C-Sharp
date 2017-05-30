using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_CSharp_Client
{
    class Bookings
    {
        /**
         * Default Constructor
         */
        public Bookings()
        {

        }

        public int id { get; set; }
        public int bookingId { get; set; }
        public String bookingMonth { get; set; }
        public String bookingDay { get; set; }
        public String bookingYear { get; set; }
        public String arrivalDate { get; set; }
        public String vacancyDate { get; set; }
        public String roomNumber { get; set; }
        public String bookingName { get; set; }
        public String destination { get; set; }
        public String departure { get; set; }
        public int hotelId { get; set; }
        public int clientId { get; set; }
    }
}
