using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class PassengerRepository : IPassengerRepository
    {
        public bool Insert(Passenger p)
        {
            try
            {
                string query = "INSERT into Passengers VALUES ("  +  p.PassengerId + ", '" + p.Pname + "', '" +
                               p.Pusername + "','" + p.Pemail + "', '" + p.Ppassword + "', '" + p.Pgender +
                               "', " + p.Page +  ", '" + p.Paddress + "', '" + p.Pquestion + "')";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                //Console.WriteLine("x= " + x);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool Update(Passenger pass)
        {
            try
            {
                string query = "UPDATE Passengers SET Name = '" + pass.Pname + "', Username = '" +
                               pass.Pusername + "', Email = '" + pass.Pemail + "', Password = '" + pass.Ppassword + "', Gender = '" + pass.Pgender +
                               "', Age = " + pass.Page +  ", Address = '" + pass.Paddress 
                               + "', Question = '" + pass.Pquestion + "' WHERE PassengerId = " + pass.PassengerId + "";
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

        public int PassengerCount()
        {
            string query = "SELECT COUNT(*) FROM Passengers";
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            int res = dcc.ExecuteSQL(query);

            Console.WriteLine(res);

            return res;
        }

        public bool Delete(int passengerId)
        {
            try
            {
                string query = "DELETE From Passengers WHERE PassengerId = " + passengerId + " ";
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

        public Passenger GetPassengers(string userId)
        {
            Passenger p = null;          

            string query = "SELECT * FROM Passengers WHERE Name LIKE '%" + userId + "%' " + " OR Username LIKE '%" + userId + "%' " + " OR Email LIKE '%" + userId + "%' ";
            string query2 = "SELECT * FROM Passengers WHERE PassengerId = " + userId + "";
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            

            float y;

            try
            {
                y = Convert.ToInt32(userId) / 2;
                y = 1;
            }
            catch (Exception er) { y = -10; }

            if (y + 1 >= 1)
            {
                SqlDataReader sdr2 = dcc.GetData(query2);
                List<Passenger> pList = new List<Passenger>();
                //id
                if (sdr2.Read())
                {
                    p = new Passenger();
                    p.PassengerId = Convert.ToInt32(sdr2["PassengerId"]);
                    p.Pusername = sdr2["Username"].ToString();
                    p.Pname = sdr2["Name"].ToString();
                    p.Pemail = sdr2["Email"].ToString();
                    p.Pgender = sdr2["Gender"].ToString();
                    p.Paddress = sdr2["Address"].ToString();
                    p.Page = Convert.ToInt32(sdr2["Age"]);
                    p.Pquestion = sdr2["Question"].ToString();
                    p.Ppassword = sdr2["Password"].ToString();

                    pList.Add(p);
                }
                dcc.CloseConnection();
                return p;
            }
            else
            {
                SqlDataReader sdr = dcc.GetData(query);
                List<Passenger> pList = new List<Passenger>();
                if (sdr.Read())
                {
                    p = new Passenger();
                    p.PassengerId = Convert.ToInt32(sdr["PassengerId"]);
                    p.Pusername = sdr["Username"].ToString();
                    p.Pname = sdr["Name"].ToString();
                    p.Pemail = sdr["Email"].ToString();
                    p.Pgender = sdr["Gender"].ToString();
                    p.Paddress = sdr["Address"].ToString();
                    p.Page = Convert.ToInt32(sdr["Age"]);
                    p.Pquestion = sdr["Question"].ToString();
                    p.Ppassword = sdr["Password"].ToString();

                    pList.Add(p);
                }
                dcc.CloseConnection();
                return p;

            }

           
            
        }

        public List<Passenger> GetAllPassengers()
        {
            string query = "SELECT * from Passengers";
            List<Passenger> pList = new List<Passenger>();
            
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Passenger p = new Passenger();
                p.PassengerId = Convert.ToInt32(sdr["PassengerId"]);
                p.Pname = sdr["Name"].ToString();
                p.Pusername = sdr["Username"].ToString();
                
                p.Pemail = sdr["Email"].ToString();
                p.Ppassword = sdr["Password"].ToString();
                p.Pgender = sdr["Gender"].ToString();
                p.Page = Convert.ToInt32(sdr["Age"]);
                p.Paddress = sdr["Address"].ToString();
                p.Pquestion = sdr["Question"].ToString();

                pList.Add(p);

            }
            dcc.CloseConnection();
            return pList;
        }
    }
}