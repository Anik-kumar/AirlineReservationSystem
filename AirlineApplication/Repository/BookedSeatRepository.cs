using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookedSeatRepository
    {
        public bool Insert(BookedSeats b)
        {
            try
            {
                string query = "INSERT into BookedSeats VALUES (" + b.FlightId + ", " + b.BookTicketId + " , '" + b.Seats + "')";
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

        /*public bool Update(BookedSeats b)
        {

            try
            {
                string query = "UPDATE BookedSeats SET Name = '" + air.AirplaneName
                                + "', Capacity = " + air.Capacity + " WHERE Aiplane Id = " + air.AirplaneId + "";
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
        }*/

        public bool Delete(int bookedTickedId)
        {

            try
            {
                string query = "DELETE From BookedSeats WHERE BookTicketId = " + bookedTickedId + " ";
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

        public List<BookedSeats> getBookedTicket(int bId)
        {
            string query = "SELECT * from BookedSeats WHERE BookTicketId  = " + bId + "";
            BookedSeats b = null;
            List<BookedSeats> bList = new List<BookedSeats>();
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                b = new BookedSeats();
                b.BookedSeatId = Convert.ToInt32(sdr["BookedSeatsId"]);
                b.Seats = sdr["Seats"].ToString();
                b.BookTicketId = Convert.ToInt32(sdr["BookTicketId"]);
                b.FlightId = Convert.ToInt32(sdr["FlightId"]);

                bList.Add(b);
            }
            dcc.CloseConnection();
            return bList;
        }

        



    }
}
