using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class FLightRepository : IFlightRepository
    {
        public bool Insert(Flight f)
        {
            //string query2 = "INSERT into Flight VALUES ('" + f.FlightId + "', '" + f.AirlineName + "', '" + f.Source + "', '" + f.Destination + "', '" + f.Arrival + "', '" + f.Departure + "', " + f.Cost + ")";
            try
            {
                string query = "INSERT into Flight VALUES ('" + f.AirlineName + "', '" + f.Source + "', '" + f.Destination + "', '" + f.Departure + "', " + f.Cost + ")";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "error database");
                //Console.WriteLine(query2);
                return false;
            }
        }

        public bool Update(Flight f)
        {
            try
            {
                string query = "UPDATE Flight SET AirlineName = '" + f.AirlineName + "', Source = '" + f.Source + "', Destination = '" + f.Destination + "', Departure = '" + f.Departure + "', Cost = " + f.Cost + " WHERE FlightId = " + f.FlightId + " ";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "error database");
                return false;
            }
        }

        public bool Delete(int flightId)
        {
            try
            {
                string query = "DELETE From Flight WHERE FlightId = " + flightId + " ";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);

                dcc.CloseConnection();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

        }

        public Flight GetFlight(string flightId)
        {
            string query = "SELECT * from Flight WHERE AirlineName LIKE '%" + flightId + "%'  ";
            Flight f = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            
            string query2 = "SELECT * from Flight WHERE FlightId = " + flightId + "";

            float y;

            try
            {
                y = Convert.ToInt32(flightId) / 2;
                y = 1;
            }
            catch (Exception er) { y = -10; }

            if (y + 1 >= 1)
            {
                SqlDataReader sdr2 = dcc.GetData(query2);
                List<Flight> fList2 = new List<Flight>();
                //id
                if (sdr2.Read())
                {
                    f = new Flight();
                    f.FlightId = Convert.ToInt32(sdr2["FlightId"]);
                    f.AirlineName = sdr2["AirlineName"].ToString();
                    f.Source = sdr2["Source"].ToString();
                    f.Destination = sdr2["Destination"].ToString();

                    f.Departure = Convert.ToString(sdr2["Departure"]);
                    f.Cost = Convert.ToInt32(sdr2["Cost"]);

                    fList2.Add(f);
                }
                dcc.CloseConnection();
                return f;

            }
            else
            {
                SqlDataReader sdr = dcc.GetData(query);
                List<Flight> fList = new List<Flight>();
                if (sdr.Read())
                {
                    f = new Flight();
                    f.FlightId = Convert.ToInt32(sdr["FlightId"]);
                    f.AirlineName = sdr["AirlineName"].ToString();
                    f.Source = sdr["Source"].ToString();
                    f.Destination = sdr["Destination"].ToString();

                    f.Departure = Convert.ToString(sdr["Departure"]);
                    f.Cost = Convert.ToInt32(sdr["Cost"]);

                    fList.Add(f);
                    //Console.WriteLine("s");
                }
                dcc.CloseConnection();
                return f;

            }

            
            dcc.CloseConnection();
            return f;
        }

        public List<Flight> GetALlFlights()
        {
            string query = "SELECT * from Flight";
            List<Flight> fList = new List<Flight>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                var f=new Flight();
                f.FlightId = Convert.ToInt32(sdr["FlightId"]);
                f.AirlineName = sdr["AirlineName"].ToString();
                f.Source = sdr["Source"].ToString();
                f.Destination = sdr["Destination"].ToString();
                f.Departure = Convert.ToString(sdr["Departure"]);
                f.Cost = Convert.ToInt32(sdr["Cost"]);

                fList.Add(f);


            }
            dcc.CloseConnection();
            return fList;
        }
    }
}