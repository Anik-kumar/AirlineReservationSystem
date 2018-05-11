using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookedSeats
    {
        private int bookTicketId;
        private int flightId;
        private int bookedSeatId;
        private string seats;

        public int BookTicketId
        {
            set { bookTicketId = value; }
            get { return bookTicketId; }
        }

        public int FlightId
        {
            set { flightId = value; }
            get { return flightId; }
        }

        public int BookedSeatId
        {
            set { bookedSeatId = value; }
            get { return bookedSeatId; }
        }

        public string Seats
        {
            set { seats = value; }
            get { return seats; }
        }

    }
}
