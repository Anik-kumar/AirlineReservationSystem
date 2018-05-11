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
    public partial class PassengerForm : Form
    {
        private int userId;

        public PassengerForm()
        {
            InitializeComponent();
        }

        public PassengerForm(int uid)
        {
            userId = uid;
            InitializeComponent();
        }

        private void bookTicketBtn_Click(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
            this.Hide();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void oooToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookTicketBtn_Click_1(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket();
            bt.Show();
            this.Hide();
        }

        private void passengerSearchBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (passengerComboBox.SelectedItem.ToString().Equals("Flight"))
                {
                    string text = this.passengerSearchTextBox.Text;
                    string query2 = "SELECT * FROM Flight WHERE FlightID = " + text + "";
                    string query = "SELECT * FROM Flight WHERE AirlineName LIKE '%" + text + "%' " + " OR Source LIKE '%" + text + "%' " + " OR Destination LIKE '%" + text + "%' " + " OR Cost LIKE '%" + text + "%' ";
                    DatabaseConnection dcc = new DatabaseConnection();
                    dcc.ConnectWithDB();

                    Flight f;

                    float y;

                    try
                    {
                        y = Convert.ToInt32(this.passengerSearchTextBox.Text) / 2;
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
                else if (passengerComboBox.SelectedItem.ToString().Equals("Airplane"))
                {


                    string text = this.passengerSearchTextBox.Text;
                    string query = "SELECT * FROM Airplane WHERE  Name LIKE '%" + text + "%' ";
                    string query2 = "SELECT * FROM Airplane WHERE AiplaneId = " + text + "";
                    DatabaseConnection dcc = new DatabaseConnection();
                    dcc.ConnectWithDB();

                    Airplane air;

                    float y;

                    try
                    {
                        y = Convert.ToInt32(this.passengerSearchTextBox.Text) / 2;
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
                else if (passengerComboBox.SelectedItem.ToString().Equals("Airport"))
                {
                    string text = this.passengerSearchTextBox.Text;
                    string query = "SELECT * FROM Airport WHERE AirportName LIKE '%" + text + "%' OR City LIKE '%" + text + "%'";
                    string query2 = "SELECT * FROM Airport WHERE AirportId = " + text + "";
                    DatabaseConnection dcc = new DatabaseConnection();
                    dcc.ConnectWithDB();

                    Airport air1;


                    float y;

                    try
                    {
                        y = Convert.ToInt32(this.passengerSearchTextBox.Text) / 2;
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
                            air1.AirportName = sdr2["AirportName"].ToString();
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
                            air1.AirportName = sdr["AirportName"].ToString();
                            air1.City = sdr["City"].ToString();

                            air1List.Add(air1);

                        }
                        this.dataGridView2.DataSource = air1List;


                    }
                }
                else if (passengerComboBox.SelectedItem.ToString().Equals("Booked Flight"))
                {
                    string text = this.passengerSearchTextBox.Text;
                    string query = "SELECT * FROM BookTicket WHERE PassengerUsername LIKE '%" + text + "%' OR Seats LIKE '%" + text + "%' OR PassengerFullName LIKE '%" + text + "%' ";
                    string query2 = "SELECT * FROM BookTicket WHERE BookTicketId = " + userId + " OR PassengerId LIKE " + text + " OR FlightId LIKE " + text + "";
                    DatabaseConnection dcc = new DatabaseConnection();
                    dcc.ConnectWithDB();

                    Repository.BookTicket b;
                    

                    float y;

                    try
                    {
                        y = Convert.ToInt32(this.passengerSearchTextBox.Text) / 2;
                        y = 1;
                    }
                    catch (Exception er) { y = -10; }


                    if (y + 1 >= 1)
                    {
                        SqlDataReader sdr2 = dcc.GetData(query2);
                        List<Repository.BookTicket> bList = new List<Repository.BookTicket>();
                        //id
                        if (sdr2.Read())
                        {
                            b = new Repository.BookTicket();


                            b.BookTicketId = Convert.ToInt32(sdr2["BookTicketId"]);
                            b.PassengerId = Convert.ToInt32(sdr2["PassengerId"]);
                            b.FlightId = Convert.ToInt32(sdr2["FlightId"]);
                            b.PassengerUsername = sdr2["PassengerUsername"].ToString();
                            b.PassengerUsername = sdr2["PassengerFullName"].ToString();
                            b.Airplane = sdr2["Airplane"].ToString();
                            b.Source = sdr2["Source"].ToString();
                            b.Destination = sdr2["Destination"].ToString();
                            b.Departure = sdr2["Departure"].ToString();
                            b.Seats = sdr2["Seats"].ToString();
                            b.Cost = Convert.ToInt32(sdr2["Cost"]);

                            bList.Add(b);

                        }
                        this.dataGridView2.DataSource = bList;
                    }
                    else
                    {
                        SqlDataReader sdr = dcc.GetData(query);
                        List<Repository.BookTicket> bList = new List<Repository.BookTicket>();
                        if (sdr.Read())
                        {
                            b = new Repository.BookTicket();


                            b.BookTicketId = Convert.ToInt32(sdr["BookTicketId"]);
                            b.PassengerId = Convert.ToInt32(sdr["PassengerId"]);
                            b.FlightId = Convert.ToInt32(sdr["FlightId"]);
                            b.PassengerUsername = sdr["PassengerUsername"].ToString();
                            b.PassengerUsername = sdr["PassengerFullName"].ToString();
                            b.Airplane = sdr["Airplane"].ToString();
                            b.Source = sdr["Source"].ToString();
                            b.Destination = sdr["Destination"].ToString();
                            b.Departure = sdr["Departure"].ToString();
                            b.Seats = sdr["Seats"].ToString();
                            b.Cost = Convert.ToInt32(sdr["Cost"]);

                            bList.Add(b);

                        }
                        this.dataGridView2.DataSource = bList;


                    }

                }
                else
                {
                    MessageBox.Show("Search error");
                }
            }catch(Exception er)
            {
                MessageBox.Show("Nothing to search. Write something in Search Box");
            }
            
        }

        private void bookTicketBtn_Click_2(object sender, EventArgs e)
        {
            BookTicket bt = new BookTicket(userId);
            bt.Show();
            this.Hide();
        }

        private void loadFlightsBtn_Click(object sender, EventArgs e)
        {
            FLightRepository flightRepo = new FLightRepository();

            List<Flight> flightList = flightRepo.GetALlFlights();

            this.dataGridView2.DataSource = flightList;
        }

        private void loadBookedFilghts_Click(object sender, EventArgs e)
        {
            Repository.BookTicket bt = new Repository.BookTicket();
            BookTicketRepository btRepo = new BookTicketRepository();

            List<Repository.BookTicket> btList = btRepo.GetTicket(userId);
            Console.WriteLine(btList.Count);

            if(btList.Count == 0)
            {
                MessageBox.Show("You Have Not Booked Any Ticket. \nPlease Book a Ticket First.");
            }
            else
            {
                dataGridView2.DataSource = btList;
            }


        }

        private void viewAirports_Click(object sender, EventArgs e)
        {
            AirportRepository airRepo = new AirportRepository();

            List<Airport> airList = airRepo.GetAllAirports();

            this.dataGridView2.DataSource = airList;
        }

        private void viewAirplaneBtn_Click(object sender, EventArgs e)
        {
            AirplaneRepository airPlane = new AirplaneRepository();

            List<Airplane> airList = airPlane.GetAllAirplanes();

            this.dataGridView2.DataSource = airList;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //logout btn 
            LoginForm lform = new LoginForm();
            lform.Show();
            this.Hide();
        }

        private void PassengerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cancel ticket btn pform
            CancelForm cform = new CancelForm(userId);
            cform.Show();
            this.Hide();


        }
    }
}
