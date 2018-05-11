using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using System.Data.SqlClient;

namespace AirlineApplication
{
    public partial class AdminHomeForm : Form
    {
        //private int flightCount = 0;
        private int userId;

        public AdminHomeForm()
        {
            InitializeComponent();
            ClearAll();

        }

        public AdminHomeForm(int uid)
        {
            userId = uid;

            InitializeComponent();
            ClearAll();

        }

        private void addNewFlightTab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addFlightsTab_Click(object sender, EventArgs e)
        {

        }

        private void viewFlightTab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                this.flightIdtextBox.Text = row.Cells["FlightId"].Value.ToString();
                this.textBox26.Text = row.Cells["AirlineName"].Value.ToString();
                this.textBox27.Text = row.Cells["Source"].Value.ToString();
                this.textBox28.Text = row.Cells["Destination"].Value.ToString();
                this.dateTimePicker3.Text = row.Cells["Departure"].Value.ToString();
                this.dateTimePicker4.Text = row.Cells["Arrival"].Value.ToString();
                this.textBox31.Text = row.Cells["Cost"].Value.ToString();

            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            FLightRepository repository = new FLightRepository();
            List<Flight> flightList = repository.GetALlFlights();
            this.flightGridView1.DataSource = flightList;
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearAll();

            this.addEmpTab.SelectTab(1);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.addEmpTab.SelectTab(2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.addEmpTab.SelectTab(3);
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(0);
            ClearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add flight btn
            Flight f = new Flight();            
            
            f.AirlineName = this.textBox9.Text;
            f.Source = this.textBox10.Text;
            f.Destination = this.textBox11.Text;
            //f.Arrival = this.dateTimePicker1.Text;
            f.Departure = this.dateTimePicker2.Text;
            f.Cost = Convert.ToInt32(this.textBox14.Text);
            

            FLightRepository FlightRepo = new FLightRepository();
            if (FlightRepo.Insert(f))
            {
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.textBox11.Text = "";                
                this.textBox14.Text = "";
                //dateTimePicker1.Text = DateTime.Today.ToString();
                dateTimePicker2.Text = DateTime.Today.ToString();

                MessageBox.Show("Successfully Added", "Done");
            }
            else
            {
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.textBox11.Text = "";
                this.textBox14.Text = "";
                //dateTimePicker1.Text = DateTime.Today.ToString();
                dateTimePicker2.Text = DateTime.Today.ToString();
                MessageBox.Show("Error storing Flight", "Error");
            }


        }

        private void passengerGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = passengerGridView2.Rows[e.RowIndex];

                this.textBox39.Text = row.Cells["PassengerId"].ToString();
                this.textBox40.Text = row.Cells["Name"].ToString();
                this.textBox41.Text = row.Cells["UserName"].ToString();
                this.textBox42.Text = row.Cells["Email"].ToString();
                this.textBox43.Text = row.Cells["Password"].ToString();
                this.textBox44.Text = row.Cells["Gender"].ToString();
                this.textBox45.Text = row.Cells["Age"].ToString();
                this.textBox47.Text = row.Cells["Address"].ToString();
                this.textBox48.Text = row.Cells["Question"].ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //load passenger btn
            PassengerRepository passRepo = new PassengerRepository();
            List<Passenger> passList = passRepo.GetAllPassengers();
            this.passengerGridView2.DataSource = passList;

            this.textBox39.Text = "";
            this.textBox40.Text = "";
            this.textBox41.Text = "";
            this.textBox42.Text = "";
            this.textBox43.Text = "";
            this.textBox44.Text = "";
            this.textBox45.Text = "";
            this.textBox47.Text = "";
            this.textBox48.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //search passenger btn
            string uid = this.textBox38.Text;
            PassengerRepository PassRepo = new PassengerRepository();
            Passenger passList = PassRepo.GetPassengers(uid);
                        
            this.textBox39.Text = passList.PassengerId.ToString();
            this.textBox40.Text = passList.Pname;
            this.textBox41.Text = passList.Pusername;
            this.textBox42.Text = passList.Pemail;
            this.textBox43.Text = passList.Ppassword;
            this.textBox44.Text = passList.Pgender;
            this.textBox45.Text = passList.Page.ToString();
            this.textBox47.Text = passList.Paddress;
            this.textBox48.Text = passList.Pquestion;
            List<Passenger> pList = new List<Passenger>();
            pList.Add(passList);
            this.passengerGridView2.DataSource = pList;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update passenger btn

            
                PassengerRepository PassRepo = new PassengerRepository();
                Passenger p = new Passenger();

                p.PassengerId = Convert.ToInt32(this.textBox39.Text);
                p.Pname = this.textBox40.Text;
                p.Pusername = this.textBox41.Text;
                p.Pemail = this.textBox42.Text;
                p.Ppassword = this.textBox43.Text;
                p.Pgender = this.textBox44.Text;
                p.Page = Convert.ToInt32(this.textBox45.Text);
                p.Paddress = this.textBox47.Text;
                p.Pquestion = this.textBox48.Text;

                if (PassRepo.Update(p))
                {
                    List<Passenger> pList = PassRepo.GetAllPassengers();
                    this.passengerGridView2.DataSource = pList;
                    this.textBox38.Text = "";
                    this.textBox39.Text = "";

                    this.textBox40.Text = "";
                    this.textBox41.Text = "";
                    this.textBox42.Text = "";
                    this.textBox43.Text = "";
                    this.textBox44.Text = "";
                    this.textBox45.Text = "";
                    this.textBox47.Text = "";
                    this.textBox48.Text = "";

                }
                else
                {
                    MessageBox.Show("Error", "Error");
                }
           
            


        }

        private void newRouteTab_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(0);
            ClearAll();
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(0);
            ClearAll();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(0);
            ClearAll();
        }

        private void addNewRouteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void loadUsersBtn_Click(object sender, EventArgs e)
        {
            AllUsersRepository userRepo = new AllUsersRepository();
            List<AllUsers> ulist = userRepo.GetAllUsers();

            this.userGridView1.DataSource = ulist;

        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            //add emp btn
            AllUsersRepository userRepo = new AllUsersRepository();
            AllUsers user = new AllUsers();

            user.UserFullName = textBox71.Text;
            user.UserType = "Employee";
            user.UserName = textBox72.Text;
            user.UserPassword = textBox74.Text;
            user.UserQuestion = textBox79.Text;

            

            
            EmployeeRepository empRepo = new EmployeeRepository();
            Employee emp = new Employee();

            int x = empRepo.EmployeeCount();
            x = x+1;

            Console.WriteLine("emp count : " + x);

            emp.EmployeeID = x;
            emp.Name = textBox71.Text;
            emp.Username = textBox72.Text;
            emp.Email = textBox73.Text;
            emp.Password = textBox74.Text;
            emp.Gender = textBox75.Text;
            emp.Age = Convert.ToInt32(textBox76.Text);
            emp.Address = textBox78.Text;
            emp.Question = textBox79.Text;

            if (empRepo.Insert(emp) && userRepo.Insert(user))
            {
                MessageBox.Show("New User Added");
                textBox71.Text = "";
                textBox72.Text = "";
                textBox73.Text = "";
                textBox74.Text = "";
                textBox75.Text = "";
                textBox76.Text = "";
                textBox78.Text = "";
                textBox79.Text = "";

            }
            else
            {
                MessageBox.Show("User not Added. Error adding employee to database.");
                
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //add admin btn
            AllUsersRepository userRepo = new AllUsersRepository();
            AllUsers user = new AllUsers();

            user.UserFullName = textBox81.Text;
            user.UserType = "Admin";
            user.UserName = textBox82.Text;
            user.UserPassword = textBox84.Text;
            user.UserQuestion = textBox89.Text;
                        
            AdminRepository adminRepo = new AdminRepository();
            Admin a = new Admin();

            int x = adminRepo.AdminCount();
            x = x + 1;

            a.AdminId = x;
            a.Name = textBox81.Text;
            a.Username = textBox82.Text;
            a.Email = textBox83.Text;
            a.Password = textBox84.Text;
            a.Gender = textBox85.Text;
            a.Age = Convert.ToInt32(textBox86.Text);
            a.Address = textBox88.Text;
            a.Question = textBox89.Text;
            

            if (adminRepo.Insert(a) && userRepo.Insert(user))
            {
                MessageBox.Show("New User Added");
                textBox81.Text = "";
                textBox82.Text = "";
                textBox83.Text = "";
                textBox84.Text = "";
                textBox85.Text = "";
                textBox86.Text = "";
                textBox88.Text = "";
                textBox89.Text = "";
            }
            else
            {
                MessageBox.Show("New User did not Added. Error adding admin to database.");
                
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //logout btn
            ClearAll();
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
            string uid = this.viewFlightTextBox.Text;
            FLightRepository fltRepo = new FLightRepository();
            Flight f = fltRepo.GetFlight(uid);
            List<Flight> fList = fltRepo.GetALlFlights();

            try
            {
                this.flightIdtextBox.Text = f.FlightId.ToString();
                this.textBox26.Text = f.AirlineName;
                this.textBox27.Text = f.Source;
                this.textBox28.Text = f.Destination;
                this.dateTimePicker3.Text = f.Departure;
                //this.dateTimePicker4.Text = f.Arrival;
                this.textBox31.Text = Convert.ToString(f.Cost);

                this.passengerGridView2.DataSource = fList[0];
            }
            catch(Exception er)
            {
                MessageBox.Show("No Result Found");
            }


        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            FLightRepository flightRepo = new FLightRepository();
            Flight f = new Flight();

            f.FlightId = Convert.ToInt32(this.flightIdtextBox.Text);
            f.AirlineName = this.textBox26.Text;
            f.Source = this.textBox27.Text;
            f.Destination = this.textBox28.Text;
            f.Departure = this.dateTimePicker3.Text;
            //f.Arrival = this.dateTimePicker4.Text;
            f.Cost = Convert.ToInt32(this.textBox31.Text);

            if (flightRepo.Update(f))
            {
                List<Flight> fList = flightRepo.GetALlFlights();

                this.employeeGridView.DataSource = fList;
                this.flightIdtextBox.Text = "";
                this.textBox26.Text = "";
                this.textBox27.Text = "";
                this.textBox28.Text = "";
                this.dateTimePicker3.Text = "";
                this.dateTimePicker4.Text = "";
                this.textBox31.Text = "";

            }
            else
            {
                MessageBox.Show("Error", "Error");
            }

        }

        private void viewAllUsersBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.addEmpTab.SelectTab(4);
            
        }

        private void addemployeeBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.addEmpTab.SelectTab(5);
            
        }

        private void addAdminBtn2_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.addEmpTab.SelectTab(6);
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //
            EmployeeRepository empRepo = new EmployeeRepository();
            List<Employee> empList = empRepo.GetAllEmployees();
            this.employeeGridView.DataSource = empList;

            this.EmployeeSearchBox.Text = "";
            this.emptextBox3.Text = "";
            this.emptextBox4.Text = "";
            this.emptextBox1.Text = "";
            this.emptextBox5.Text = "";
            this.emptextBox6.Text = "";
            this.emptextBox7.Text = "";
            this.emptextBox8.Text = "";
            this.emptextBox9.Text = "";
            this.emptextBox2.Text = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //search emp
            string uid = this.EmployeeSearchBox.Text;
            EmployeeRepository empRepo = new EmployeeRepository();
            Employee emp = empRepo.GetEmployees(uid);

            this.emptextBox1.Text = emp.EmployeeID.ToString();
            this.emptextBox2.Text = emp.Name;
            this.emptextBox3.Text = emp.Username;
            this.emptextBox4.Text = emp.Email;
            this.emptextBox5.Text = emp.Password;
            this.emptextBox6.Text = emp.Gender;
            this.emptextBox7.Text = emp.Age.ToString();
            this.emptextBox8.Text = emp.Address;
            this.emptextBox9.Text = emp.Question; 
            this.employeeGridView.DataSource = emp;


        }

        private void empUpdate_Click(object sender, EventArgs e)
        {
            EmployeeRepository empRepo = new EmployeeRepository();
            Employee emp = new Employee();

            emp.EmployeeID = Convert.ToInt32(this.emptextBox1.Text);
            emp.Name = this.emptextBox2.Text;
            emp.Username = this.emptextBox3.Text;
            emp.Email = this.emptextBox4.Text;
            emp.Password = this.emptextBox5.Text;
            emp.Gender = this.emptextBox6.Text;
            emp.Age = Convert.ToInt32(this.emptextBox7.Text);
            emp.Address = this.emptextBox8.Text;
            emp.Question = this.emptextBox9.Text;
                       
            if (empRepo.Update(emp))
            {
                List<Employee> empList = empRepo.GetAllEmployees();

                this.employeeGridView.DataSource = empList;
                this.emptextBox3.Text = "";
                this.emptextBox4.Text = "";
                this.emptextBox1.Text = "";
                this.emptextBox6.Text = "";
                this.emptextBox7.Text = "";
                this.emptextBox8.Text = "";
                this.emptextBox9.Text = "";
                this.emptextBox2.Text = "";

            }
            else
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //delete flight btn
            Flight f = new Flight();

            f.FlightId = Convert.ToInt32(flightIdtextBox.Text);

            FLightRepository fRepo = new FLightRepository();


            if (fRepo.Delete(f.FlightId))
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("error deleting flight");
            }

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            //delete passenger btn
            PassengerRepository pRepo = new PassengerRepository();
            Passenger p = new Passenger();

            p.PassengerId = Convert.ToInt32(textBox38.Text);

            if (pRepo.Delete(p.PassengerId))
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Error deleting passenger");
            }


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //delete emp btn
            EmployeeRepository empRepo = new EmployeeRepository();

            Employee emp = new Employee();

            emp.EmployeeID = Convert.ToInt32(emptextBox1.Text);

            if (empRepo.Delete(emp.EmployeeID))
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Error deleting employee");
            }
            
        }

        private void searchAllBtn_Click(object sender, EventArgs e)
        {

            string uid = this.searchAlltextBox1.Text;
            AllUsersRepository userRepo = new AllUsersRepository();
            List<AllUsers> aList = new List<AllUsers>();
            AllUsers a = userRepo.GetUser(uid);

            aList.Add(a);
            

            userGridView1.DataSource = aList;

            
        }

        private void viewEmpsBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.addEmpTab.SelectTab(7);
        }

        private void employeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.employeeGridView.Rows[e.RowIndex];

                this.emptextBox1.Text = row.Cells["EmpId"].ToString();
                this.emptextBox2.Text = row.Cells["Name"].ToString();
                this.emptextBox3.Text = row.Cells["Username"].ToString();
                this.emptextBox4.Text = row.Cells["Email"].ToString();
                this.emptextBox5.Text = row.Cells["Password"].ToString();
                this.emptextBox6.Text = row.Cells["Gender"].ToString();
                this.emptextBox7.Text = row.Cells["Age"].ToString();
                this.emptextBox8.Text = row.Cells["Address"].ToString();
                this.emptextBox9.Text = row.Cells["Question"].ToString();

            }
        }

        private void viewAllUserTab_Click(object sender, EventArgs e)
        {

        }

        private void bactBtn_Click(object sender, EventArgs e)
        {
            this.addEmpTab.SelectTab(0);
            ClearAll();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            ClearAll();
            this.addEmpTab.SelectTab(0);
            
        }

        public void ClearAll()
        {
            EmployeeSearchBox.Text = "";
            searchAlltextBox1.Text = "";
            viewFlightTextBox.Text = "";
            flightIdtextBox.Text = "";
            //dateTimePicker1.Text = DateTime.Now.ToString();
            dateTimePicker2.Text = DateTime.Now.ToString();
            dateTimePicker3.Text = DateTime.Now.ToString();
            dateTimePicker4.Text = DateTime.Now.ToString();

            flightGridView1.DataSource = null;
            employeeGridView.DataSource = null;
            userGridView1.DataSource = null;
            passengerGridView2.DataSource = null;

            emptextBox1.Text = "";
            emptextBox2.Text = "";
            emptextBox3.Text = "";
            emptextBox4.Text = "";
            emptextBox5.Text = "";
            emptextBox6.Text = "";
            emptextBox7.Text = "";
            emptextBox8.Text = "";
            emptextBox9.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox31.Text = "";

            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";
            textBox47.Text = "";
            textBox48.Text = "";

            textBox71.Text = "";
            textBox72.Text = "";
            textBox73.Text = "";
            textBox74.Text = "";
            textBox75.Text = "";
            textBox76.Text = "";
            textBox78.Text = "";
            textBox79.Text = "";

            textBox81.Text = "";
            textBox82.Text = "";
            textBox83.Text = "";
            textBox84.Text = "";
            textBox85.Text = "";
            textBox86.Text = "";
            textBox88.Text = "";
            textBox89.Text = "";
            textBox84.PasswordChar = '*';
            textBox74.PasswordChar = '*';
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            textBox84.PasswordChar = '\0';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox74.PasswordChar = '\0';
        }
    }
}
