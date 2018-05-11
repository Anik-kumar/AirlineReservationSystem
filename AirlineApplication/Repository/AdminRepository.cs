using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class AdminRepository : IAdminRepository
    {
        public bool Insert(Admin a)
        {
            try
            {
                string query = "INSERT into Admin VALUES ( " + a.AdminId + ", '" + a.Name + "', '" +
                               a.Username + "','" + a.Email + "', '" + a.Password + "', '" + a.Gender +
                               "',"+a.Age+", '" + a.Address + "','"+a.Question +"')";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                //Console.WriteLine("x= " + x);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool Update(Admin a)
        {
            try
            {
                string query = "UPDATE Admin SET Name = '" + a.Name + "', Username = '" 
                                + a.Username + "', Email = '" + a.Email + "', Password = '" + a.Password + "', Gender = '" + a.Gender +
                               "', Age = " + a.Age + ", Address = '"
                               + a.Address + "', Question = '" + a.Question + "' WHERE AdminId = " + a.AdminId + "";
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

        public int AdminCount()
        {
            string query = "SELECT COUNT(*) FROM Admin";
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            int res = dcc.ExecuteSQL(query);

            Console.WriteLine(res);

            return res;
        }

        public bool Delete(string adminId)
        {
            try
            {
                string query = "DELETE From Admin WHERE AdminId = " + adminId + " ";
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




      

        public Admin GetAdmins(string adminId)
        {
            string query = "SELECT * from Admin WHERE Name LIKE '%" + adminId + "'% OR Username LIKE '" + adminId + "'";
            Admin a = null;                       
            string query2 = "SELECT * FROM Passengers WHERE AdminId = " + adminId + "";
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();          


            float y;

            try
            {
                y = Convert.ToInt32(adminId) / 2;
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
                    a = new Admin();
                    a.AdminId = Convert.ToInt32(sdr2["AdminId"]);
                    a.Username = sdr2["Username"].ToString();
                    a.Name = sdr2["Name"].ToString();
                    a.Email = sdr2["Email"].ToString();
                    a.Gender = Convert.ToString(sdr2["Gender"]);
                    a.Address = sdr2["Address"].ToString();
                    a.Age = Convert.ToInt32(sdr2["Age"]);
                    a.Question = sdr2["Question"].ToString();
                    a.Password = sdr2["Password"].ToString();
                    
                }
                dcc.CloseConnection();
                return a;

            }
            else
            {
                SqlDataReader sdr = dcc.GetData(query);
                List<Passenger> pList = new List<Passenger>();
                if (sdr.Read())
                {
                    a = new Admin();
                    a.AdminId = Convert.ToInt32(sdr["AdminId"]);
                    a.Username = sdr["Username"].ToString();
                    a.Name = sdr["Name"].ToString();
                    a.Email = sdr["Email"].ToString();
                    a.Gender = Convert.ToString(sdr["Gender"]);
                    a.Address = sdr["Address"].ToString();
                    a.Age = Convert.ToInt32(sdr["Age"]);
                    a.Question = sdr["Question"].ToString();
                    a.Password = sdr["Password"].ToString();
                    
                }
                dcc.CloseConnection();
                return a;
                
            }
                       
        }

        public List<Admin> GetAllAdmins()
        {
            string query = "SELECT * from Admin";
            List<Admin> aList = new List<Admin>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Admin a = new Admin();
                a.AdminId = Convert.ToInt32(sdr["AdminId"]);
                a.Username = sdr["Username"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Email = sdr["Email"].ToString();
                a.Gender = Convert.ToString(sdr["Gender"]);
                a.Address = sdr["Address"].ToString();
               
                a.Age = Convert.ToInt32(sdr["Age"]);
                a.Question = sdr["Question"].ToString();
                a.Password = sdr["Password"].ToString();
                


                aList.Add(a);

            }
            dcc.CloseConnection();
            return aList;
        }
    }
}