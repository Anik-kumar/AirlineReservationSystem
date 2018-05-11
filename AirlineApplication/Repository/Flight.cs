using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Flight
    {
        private int flightId;
        private string airlineName;
        private string source;
        private string destination;
        
        private string departure;
        private int cost;

        public int FlightId
        {
            get { return this.flightId; }
            set { this.flightId = value; }
        }

        public string AirlineName
        {
            get { return this.airlineName; }
            set { this.airlineName = value; }
        }

        public string Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        public string Destination
        {
            get { return this.destination; }
            set { this.destination = value; }
        }

        

        public string Departure
        {
            get { return this.departure; }
            set { this.departure = value; }
        }

        public int Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

    
    }
}
