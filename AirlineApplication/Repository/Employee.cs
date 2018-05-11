namespace Repository
{
    public class Employee
   {
       private int employeeId;
       private string name;
       private string username;
       private string email;
       private string password;
       private string gender;
       private int age;
       private string address;
       private string question;

       public int EmployeeID
       {
           get { return this.employeeId; }
           set { this.employeeId = value; }
       }
       public string Name
       {
           get { return this.name; }
           set { this.name = value; }
       }
       public string Username
       {
           get { return this.username; }
           set { this.username = value; }
       }
       public string Email
       {
           get { return this.email; }
           set { this.email = value; }
       }
       public string Password
       {
           get { return this.password; }
           set { this.password = value; }
       }
       public string Gender
       {
           get { return this.gender; }
           set { this.gender = value; }
       }
       public int Age
       {
           get { return this.age; }
           set { this.age = value; }
       }
       
       public string Address
       {
           get { return this.address; }
           set { this.address = value; }
       }
       public string Question
       {
           get { return this.question; }
           set { this.question = value; }
       }
       
       

    }
}