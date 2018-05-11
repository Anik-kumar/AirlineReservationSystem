using System;

namespace Repository
{
    public class BookTicket
    {
        private int bookTicketId;
        private int cost;
        private int flightId;
        private int passengerId;
        private string airplane;
        private string passengerFullName;

        private string passengerUsername;
        private string departure;
        private string seats;                
        private string source;
        private string destination;

        public int Cost
        {
            get { return cost; }
            set { this.cost = value; }
        }

        public int FlightId
        {
            get { return flightId; }
            set { this.flightId = value; }
        }

        public int BookTicketId
        {
            get { return  bookTicketId; }
            set { this.bookTicketId = value; }
        }

        public int PassengerId
        {
            get { return passengerId; }
            set { passengerId = value; }
        }
        

        public string Airplane
        {
            get { return airplane; }
            set { this.airplane = value; }
        }

        public string PassengerUsername
        {
            get { return passengerUsername; }
            set { this.passengerUsername = value; }
        }

        public string PassengerFullName
        {
            get { return passengerFullName; }
            set { this.passengerFullName = value; }
        }

        public string Source
        {
            get { return source; }
            set { this.source = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { this.destination = value; }
        }

        public string Departure
        {
            get { return departure; }
            set { this.departure = value; }
        }

        

        public string Seats
        {
            get { return seats; }
            set { this.seats = value; }
        }


        
    }
}