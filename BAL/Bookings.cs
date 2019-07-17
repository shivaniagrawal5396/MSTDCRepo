using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Bookings
    {
        public int Bookingid { get; set; }
        public string BookingName { get; set; }
        public int UserId { get; set; }
        public DateTime StatTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool BookingStatus { get; set; }
        public int ReservationToken { get; set; }
        public DateTime TimeStamp { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public int NumberOfRooms { get; set; }
    }
}
