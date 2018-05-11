using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AllUsersRepository : IAllUsers
    {
        public bool Delete(string userId)
        {
            try
            {
                string query = "DELETE From AllUsers WHERE UserId = '" + userId + "' ";
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

        


        public AllUsers GetUserById(int uid)
        {
            string query = "SELECT * from AllUsers WHERE UserId  = " + uid + " ";
            AllUsers au = new AllUsers();
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                //au = new AllUsers();
                au.UserId = Convert.ToInt32(sdr["UserId"]);
                au.UserFullName = sdr["Fullname"].ToString();
                au.UserName = sdr["Username"].ToString();
                au.UserType = Convert.ToString(sdr["UserType"]);
                au.UserPassword = sdr["Password"].ToString();
                au.UserQuestion = sdr["Question"].ToString();
            }
            dcc.CloseConnection();
            return au;
        }

        public AllUsers GetUser(string userId)
        {
            string query = "SELECT * FROM AllUsers WHERE UserType LIKE '%" + userId + "%' OR Username LIKE '%" + userId + "%' OR Fullname LIKE '%" + userId + "%' ";
            string query2 = "SELECT * FROM AllUsers WHERE UserId  = " + userId + "";
            AllUsers a = new AllUsers();
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
                //List<Passenger> pList = new List<Passenger>();
                //id
                if (sdr2.Read())
                {
                    
                    a.UserId = Convert.ToInt32(sdr2["UserId"]);
                    a.UserName = sdr2["Username"].ToString();
                    a.UserFullName = sdr2["Fullname"].ToString();
                    a.UserPassword = sdr2["Password"].ToString();
                    a.UserType = sdr2["UserType"].ToString();
                    a.UserQuestion = sdr2["Question"].ToString();

                    //pList.Add(a);
                }
                dcc.CloseConnection();
                return a;
            }
            else
            {
                SqlDataReader sdr = dcc.GetData(query);
                //List<Passenger> pList = new List<Passenger>();
                if (sdr.Read())
                {

                    a.UserId = Convert.ToInt32(sdr["UserId"]);
                    a.UserName = sdr["Username"].ToString();
                    a.UserFullName = sdr["Fullname"].ToString();
                    a.UserPassword = sdr["Password"].ToString();
                    a.UserType = sdr["UserType"].ToString();
                    a.UserQuestion = sdr["Question"].ToString();

                    //pList.Add(a);
                }
                dcc.CloseConnection();
                return a;

            }

            
        }

        public List<AllUsers> GetAllUsers()
        {
            string query = "SELECT * from AllUsers";
            List<AllUsers> userList = new List<AllUsers>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                AllUsers a = new AllUsers();
                a.UserId = Convert.ToInt32(sdr["UserId"]);
                a.UserFullName = sdr["Fullname"].ToString();
                a.UserName = sdr["Username"].ToString();
                a.UserPassword = sdr["Password"].ToString();
                a.UserType = Convert.ToString(sdr["UserType"]);
                a.UserQuestion = sdr["Question"].ToString();
                userList.Add(a);

            }
            dcc.CloseConnection();
            return userList;
        }

        public bool Insert(AllUsers a)
        {
            try
            {
                string query = "INSERT into AllUsers VALUES ('" + a.UserFullName + "', '" 
                                + a.UserName + "', '" + a.UserPassword +"', '" + a.UserType + "', '" + a.UserQuestion + "')";
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

        public bool Update(AllUsers a)
        {
            try
            {
                string query = "UPDATE AllUsers SET Fullname = '" + a.UserFullName
                                + "', Username = '" + a.UserName + "', Password = '" 
                                + a.UserPassword + "', UserType = '" + a.UserType + "' WHERE UserId = " + a.UserId + "";
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
    }
}
