using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookTicketRepository
    {

        public bool Insert(BookTicket bTicket)
        {
            try
            {
                string query = "INSERT into BookTicket VALUES ( " + bTicket.BookTicketId + ", " + bTicket.PassengerId + ", " + bTicket.FlightId + " , '" + bTicket.PassengerFullName + "', '" + bTicket.PassengerUsername +  "', '"  + bTicket.Airplane + "', '" + bTicket.Source + "', '" + bTicket.Destination + "', '" + bTicket.Departure + "', " + bTicket.Cost + " , '" + bTicket.Seats + "')";
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

        public bool Delete(int userId)
        {
            try
            {
                string query = "DELETE From BookTicket WHERE BTId = " + userId + " ";
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

        public int TicketCount()
        {
            string query = "SELECT COUNT(*) FROM BookTicket";
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            int res = dcc.ExecuteSQL(query);

            Console.WriteLine(res);

            return res;
        }



        public List<BookTicket> GetTicket(int ticketId)
        {
            string query = "SELECT * from BookTicket WHERE BTId  = " + ticketId + "";
            BookTicket b = null;
            List<BookTicket> blist = new List<BookTicket>();
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                b = new BookTicket();
                b.BookTicketId = Convert.ToInt32(sdr["BTId"]);
                b.PassengerId = Convert.ToInt32(sdr["PassengerId"]);
                b.FlightId = Convert.ToInt32(sdr["FlightId"]);
                b.PassengerUsername = sdr["PassengerUsername"].ToString();
                b.PassengerFullName = sdr["PassengerFullname"].ToString();
                b.Airplane = sdr["Airplane"].ToString();
                b.Source = sdr["Source"].ToString();
                b.Destination = sdr["Destination"].ToString();
                b.Departure = sdr["Departure"].ToString();
                b.Seats = sdr["Seats"].ToString();
                b.Cost = Convert.ToInt32(sdr["Cost"]);

                blist.Add(b);

            }
            dcc.CloseConnection();
            return blist;
        }

        public bool CancelTicketByPassenger(int pId, int bId)
        {
            
            try
            {
                string query = "DELETE from BookTicket WHERE PassengerId  = " + pId + " AND BTId = " + bId + "";
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


        public BookTicket GetOneTicket(int ticketId)
        {
            string query = "SELECT * from BookTicket WHERE BTId  = " + ticketId + "";
            BookTicket b = null;
            List<BookTicket> blist = new List<BookTicket>();
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                b = new BookTicket();
                b.BookTicketId = Convert.ToInt32(sdr["BTId"]);
                b.PassengerId = Convert.ToInt32(sdr["PassengerId"]);
                b.FlightId = Convert.ToInt32(sdr["FlightId"]);
                b.PassengerUsername = sdr["PassengerUsername"].ToString();
                b.PassengerFullName = sdr["PassengerFullname"].ToString();
                b.Airplane = sdr["Airplane"].ToString();
                b.Source = sdr["Source"].ToString();
                b.Destination = sdr["Destination"].ToString();
                b.Departure = sdr["Departure"].ToString();
                b.Seats = sdr["Seats"].ToString();
                b.Cost = Convert.ToInt32(sdr["Cost"]);

                

            }
            dcc.CloseConnection();
            return b;
        }





        public List<BookTicket> GetAllTickets()
        {
            string query = "SELECT * from BookTicket";
            List<BookTicket> tList = new List<BookTicket>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                BookTicket b = new BookTicket();
                b.BookTicketId = Convert.ToInt32(sdr["BTId"]);
                b.PassengerId = Convert.ToInt32(sdr["PassengerId"]);
                b.FlightId = Convert.ToInt32(sdr["FlightId"]);
                b.PassengerUsername = sdr["PassengerUsername"].ToString();
                b.PassengerFullName = sdr["PassengerFullname"].ToString();
                b.Airplane = sdr["Airplane"].ToString();
                b.Source = sdr["Source"].ToString();
                b.Destination = sdr["Destination"].ToString();
                b.Departure = sdr["Departure"].ToString();
                b.Seats = sdr["Seats"].ToString();
                b.Cost = Convert.ToInt32(sdr["Cost"]);

                tList.Add(b);

            }
            dcc.CloseConnection();
            return tList;
        }


    }
}
