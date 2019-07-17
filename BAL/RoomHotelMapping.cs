using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class RoomHotelMapping
    {
        public int RoomHotelMappingId { get; set; }
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public int NumberOfRooms { get; set; }
        public int AvailableRooms { get; set; }
    }
}
