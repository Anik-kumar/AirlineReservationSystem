using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Repository
{
    public class Airport
    {

        private int airportId;
        private string airportName;
        private string city;
        

        public int AirportId
        {
            get { return airportId; }
            set { airportId = value; }
        }

        public string AirportName
        {
            get { return airportName; }
            set { airportName = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        

    }
}