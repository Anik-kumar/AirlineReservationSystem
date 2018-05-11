using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class AirportRepository : IAirportRepository
    {
        public bool Insert(Airport airport)
        {
            try
            {
                string query = "INSERT into Airport VALUES (" + airport.AirportId + ", '" + airport.AirportName + "', '" +
                               airport.City +  "')";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool Update(Airport airport)
        {
            try
            {
                string query = "UPDATE Airport SET Name = '" + airport.AirportName + "', City = '" +
                               airport.City +  "' WHERE AirportId = " + airport.AirportId + "";
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


        public bool Delete(string airportId)
        {

            try
            {
                string query = "DELETE From Airport WHERE AirportId = " + airportId + " ";
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


        public Airport SearchById(int text)
        {
            string query = "SELECT * from Airport WHERE AirportId = %" + text + "%";
            Airport air1 = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                air1 = new Airport();
                air1.AirportId = Convert.ToInt32(sdr["AirportId"]);
                air1.AirportName = sdr["Name"].ToString();
                air1.City = sdr["City"].ToString();

            }
            dcc.CloseConnection();
            return air1;

        }


        public Airport SearchByString(string text)
        {
            string query = "SELECT * from Airport WHERE Name = '%" + text + "%' OR City LIKE '%" + text + "%'";
            Airport air1 = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                air1 = new Airport();
                air1.AirportId = Convert.ToInt32(sdr["AirportId"]);
                air1.AirportName = sdr["Name"].ToString();
                air1.City = sdr["City"].ToString();

            }
            dcc.CloseConnection();
            return air1;

            
        }

        public Airport GetAirports(string airportId)
        {
            float x;
            Airport a1, a2;


            try
            {
                x = Convert.ToInt32(airportId) / 2;

                a1 = SearchById(Convert.ToInt32(airportId));

                return a1;

            }catch(Exception er)
            {
                a2 = SearchByString(airportId);

                return a2;
            }

                        
        }


        public List<Airport> GetAllAirports()
        {
            string query = "SELECT * from Airport";
            List<Airport> airList = new List<Airport>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Airport air1=new Airport();

                air1 = new Airport();
                air1.AirportId = Convert.ToInt32(sdr["AirportId"]);
                air1.AirportName = sdr["Name"].ToString();
                air1.City = sdr["City"].ToString();

                airList.Add(air1);

            }
            dcc.CloseConnection();
            return airList;
        }
    }
}