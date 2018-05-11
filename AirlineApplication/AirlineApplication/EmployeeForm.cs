using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;

namespace AirlineApplication
{
    public partial class EmployeeForm : Form
    {
        private int userId;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(int uid)
        {
            userId = uid;
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void empBookTicketBtn_Click(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void empSearchBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (employeeComboBox.SelectedItem.ToString().Equals("Flight"))
                {
                    string text = this.employeeSearchTextBox.Text;
                    string query2 = "SELECT * FROM Flight WHERE FlightID = " + text + "";
                    string query = "SELECT * FROM Flight WHERE AirlineName LIKE '%" + text + "%' " + " OR Source LIKE '%" + text + "%' " + " OR Destination LIKE '%" + text + "%' " + " OR Cost LIKE '%" + text + "%' ";
                    DatabaseConnection dcc = new DatabaseConnection();
                    dcc.ConnectWithDB();

                    Flight f;

                    float y;

                    try
                    {
                        y = Convert.ToInt32(this.employeeSearchTextBox.Text) / 2;
                        y = 1;
                    }
                    catch (Exception er) { y = -10; }

                    if (y + 1 >= 1)
                    {
                        SqlDataReader sdr2 = dcc.GetData(query2);
                        List<Flight> fList2 = new List<Flight>();
                        //id
                        if (sdr2.Read())
                        {
                            f = new Flight();
                            f.FlightId = Convert.ToInt32(sdr2["FlightID"]);
                            f.AirlineName = sdr2["AirlineName"].ToString();
                            f.Source = sdr2["Source"].ToString();
                            f.Destination = sdr2["Destination"].ToString();

                            f.Departure = Convert.ToString(sdr2["Departure"]);
                            f.Cost = Convert.ToInt32(sdr2["Cost"]);

                            fList2.Add(f);
                        }
                        this.dataGridView2.DataSource = fList2;
                    }
                    else
                    {
                        SqlDataReader sdr = dcc.GetData(query);
                        List<Flight> fList = new List<Flight>();
                        if (sdr.Read())
                        {
                            f = new Flight();
                            f.FlightId = Convert.ToInt32(sdr["FlightID"]);
                            f.AirlineName = sdr["AirlineName"].ToString();
                            f.Source = sdr["Source"].ToString();
                            f.Destination = sdr["Destination"].ToString();

                            f.Departure = Convert.ToString(sdr["Departure"]);
                            f.Cost = Convert.ToInt32(sdr["Cost"]);

                            fList.Add(f);
                            //Console.WriteLine("s");
                        }

                        this.dataGridView2.DataSource = fList;
                    }



                }
                else if (employeeComboBox.SelectedItem.ToString().Equals("Airplane"))
                {


                    string text = this.employeeSearchTextBox.Text;
                    string query = "SELECT * FROM Airplane WHERE  Name LIKE '%" + text + "%' ";
                    string query2 = "SELECT * FROM Airplane WHERE AiplaneId = " + text + "";
                    DatabaseConnection dcc = new DatabaseConnection();
                    dcc.ConnectWithDB();

                    Airplane air;

                    float y;

                    try
                    {
                        y = Convert.ToInt32(this.employeeSearchTextBox.Text) / 2;
                        y = 1;
                    }
                    catch (Exception er) { y = -10; }

                    if (y + 1 >= 1)
                    {
                        SqlDataReader sdr2 = dcc.GetData(query2);
                        List<Airplane> airList = new List<Airplane>();
                        //id
                        if (sdr2.Read())
                        {
                            air = new Airplane();
                            air.AirplaneId = Convert.ToInt32(sdr2["AiplaneId"]);
                            air.AirplaneName = sdr2["Name"].ToString();
                            air.Capacity = Convert.ToInt32(sdr2["Capacity"]);

                            airList.Add(air);
                        }
                    }
                    else
                    {
                        SqlDataReader sdr = dcc.GetData(query);
                        List<Airplane> airList = new List<Airplane>();
                        if (sdr.Read())
                        {
                            air = new Airplane();
                            air.AirplaneId = Convert.ToInt32(sdr["AiplaneId"]);
                            air.AirplaneName = sdr["Name"].ToString();
                            air.Capacity = Convert.ToInt32(sdr["Capacity"]);

                            airList.Add(air);

                        }
                        this.dataGridView2.DataSource = airList;


                    }


                }
                else if (employeeComboBox.SelectedItem.ToString().Equals("Airport"))
                {
                    string text = this.employeeSearchTextBox.Text;
                    string query = "SELECT * FROM Airport WHERE AirportName LIKE '%" + text + "%' ";
                    string query2 = "SELECT * FROM Airport WHERE AirportId = " + text + "";
                    DatabaseConnection dcc = new DatabaseConnection();
                    dcc.ConnectWithDB();

                    Airport air1;


                    float y;

                    try
                    {
                        y = Convert.ToInt32(this.employeeSearchTextBox.Text) / 2;
                        y = 1;
                    }
                    catch (Exception er) { y = -10; }

                    if (y + 1 >= 1)
                    {
                        SqlDataReader sdr2 = dcc.GetData(query2);
                        List<Airport> air1List = new List<Airport>();
                        //id
                        if (sdr2.Read())
                        {
                            air1 = new Airport();

                            air1.AirportId = Convert.ToInt32(sdr2["AirportID"]);
                            air1.AirportName = sdr2["Name"].ToString();
                            air1.City = sdr2["City"].ToString();

                            air1List.Add(air1);

                        }

                        this.dataGridView2.DataSource = air1List;

                    }
                    else
                    {
                        SqlDataReader sdr = dcc.GetData(query);
                        List<Airport> air1List = new List<Airport>();
                        if (sdr.Read())
                        {
                            air1 = new Airport();

                            air1.AirportId = Convert.ToInt32(sdr["AirportID"]);
                            air1.AirportName = sdr["Name"].ToString();
                            air1.City = sdr["City"].ToString();

                            air1List.Add(air1);

                        }
                        this.dataGridView2.DataSource = air1List;


                    }


                }
                else if (employeeComboBox.SelectedItem.ToString().Equals("Passengers"))
                {
                    string text = this.employeeSearchTextBox.Text;
                    string query = "SELECT * FROM Passengers WHERE Name LIKE '%" + text + "%' " + " OR UserName LIKE '%" + text + "%' " + " OR Email LIKE '%" + text + "%' ";
                    string query2 = "SELECT * FROM Passengers WHERE PassengerId = " + text + "";
                    DatabaseConnection dcc = new DatabaseConnection();
                    dcc.ConnectWithDB();

                    Passenger p;


                    float y;

                    try
                    {
                        y = Convert.ToInt32(this.employeeSearchTextBox.Text) / 2;
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
                        this.dataGridView2.DataSource = pList;

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
                        this.dataGridView2.DataSource = pList;


                    }



                }
                else
                {
                    MessageBox.Show("Search error");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Nothing to search. Write something in Search Box");

            }
            
           
        }

        private void empBookTicketBtn_Click_1(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
            this.Hide();
        }

        private void viewFlights_Click(object sender, EventArgs e)
        {
            FLightRepository flightRepo = new FLightRepository();

            List<Flight> flightList = flightRepo.GetALlFlights();

            this.dataGridView2.DataSource = flightList;
        }

        private void viewPassengers_Click(object sender, EventArgs e)
        {
            PassengerRepository passRepo = new PassengerRepository();

            List<Passenger> passList = passRepo.GetAllPassengers();

            this.dataGridView2.DataSource = passList;
        }

        private void viewAirplanesBtn_Click(object sender, EventArgs e)
        {
            AirplaneRepository airPlane = new AirplaneRepository();

            List<Airplane> airList = airPlane.GetAllAirplanes();

            this.dataGridView2.DataSource = airList;
        }

        private void viewAirportBtn_Click(object sender, EventArgs e)
        {
            AirportRepository airRepo = new AirportRepository();

            List<Airport> airList = airRepo.GetAllAirports();

            this.dataGridView2.DataSource = airList;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
