using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DatabaseConnection
    {
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        private SqlDataAdapter con;

        public DatabaseConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ANiK\Documents\arsDB2.mdf;Integrated Security=True;Connect Timeout=30";
            myConnection = new SqlConnection(connectionString);


        }

        public DataTable dbConnect(String query)
        {

            SqlDataAdapter sda = new SqlDataAdapter(query, myConnection);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);

            return tbl;

        }



        public void ConnectWithDB()
        {
            myConnection.Open();
        }

        public void CloseConnection()
        {
            myConnection.Close();
        }
        public SqlDataReader GetData(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            return myCommand.ExecuteReader();
            //SqlDataReader sdr = myCommand.ExecuteReader();
            //return sdr;
        }

        public int ExecuteSQL(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //int x = myCommand.ExecuteNonQuery();
            //return x;
            return myCommand.ExecuteNonQuery();
        }

    }
}
