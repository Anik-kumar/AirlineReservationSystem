using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AllUsers
    {
        private int userId;
        private string userName;
        private string userFullName;
        private string userType;
        private string userPassword;
        private string userQuestion;



        public int UserId
        {
            set { userId = value; }
            get { return userId; }
        }

        public string UserName
        {
            set { userName = value; }
            get { return userName; }
        }

        public string UserType
        {
            set { userType = value; }
            get { return userType; }
        }

        public string UserPassword
        {
            set { userPassword = value; }
            get { return userPassword; }
        }

        public string UserFullName
        {
            set { userFullName = value; }
            get { return userFullName; }
        }

        public string UserQuestion
        {
            set { userQuestion = value; }
            get { return userQuestion; }
        }

    }
}
