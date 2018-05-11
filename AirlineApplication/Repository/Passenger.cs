using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Passenger
    {
       private int passengerId;
       private string name;
       private string username;
       private string email;
       private string password;
       private string gender;
       private int age;
       private string address;
       private string question;

        public int PassengerId
        {
            get { return this.passengerId; }
            set { this.passengerId = value; }
        }

        public string Pname
       {
           get { return this.name;}
           set { this.name = value; }
       }
       public string Pusername
       {
           get { return this.username; }
           set { this.username = value; }
       }

       public string Pemail
       {
           get { return this.email; }
           set { this.email = value; }
       }

       public string Ppassword
       {
           get { return this.password; }
           set { this.password = value; }
       }


       public string Pgender
       {
           get { return this.gender; }
           set { this.gender = value; }
       }

       public int Page
       {
           get { return this.age; }
           set { this.age = value; }
       }

       

       public string Paddress
       {
           get { return this.address; }
           set { this.address = value; }
       }

       public string Pquestion
       {
           get { return this.question; }
           set { this.question = value; }
       }

       

    }
}
