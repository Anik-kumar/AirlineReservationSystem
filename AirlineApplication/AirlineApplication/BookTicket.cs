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
    public partial class BookTicket : Form
    {
        public int passId;
        private int seatCount = 0;
        int cost;
        int tmp = 0;

        public BookTicket()
        {
            InitializeComponent();
        }

        public BookTicket( int uid)
        {
            passId = uid;
            InitializeComponent();
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load flights btn
            FLightRepository fRepo = new FLightRepository();
            List<Flight> fList = fRepo.GetALlFlights();

            bookTicketGridView.DataSource = fList;
            Clear();


        }


        public void flightLabel_click(Object sender, EventArgs e)
        {
            /*this.bookTicketTabs.SelectTab(1);
            Label lbl = (Label)sender;

            string[] text = lbl.Text.Split(',', '-');


            airplaneLabel.Text = text[1];
            fromComboBox.SelectedText = text[3];
            toComboBox.SelectedText = text[5];
            dateTimePicker1.Text = text[7];
            
            costLabel.Text = text[11];
            */

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void seat1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            seatLabel.Text = seatLabel.Text + ", " + btn.Text;
            btn.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void submitBookTicketBtn_Click(object sender, EventArgs e)
        {
            Repository.BookTicket bt = new Repository.BookTicket();
            BookTicketRepository bookRepo = new BookTicketRepository();
            BookedSeatRepository bsRepo = new BookedSeatRepository();
            BookedSeats bs = new BookedSeats();

            bs.BookTicketId = Convert.ToInt32(ticketIdLabel.Text);
            bs.FlightId = Convert.ToInt32(flightIdLabel.Text);
            bs.Seats = seatLabel.Text;

            

            
            bt.FlightId = Convert.ToInt32(flightIdLabel.Text);
            bt.PassengerId = Convert.ToInt32(passengerIdLabel.Text);
            bt.BookTicketId = Convert.ToInt32(ticketIdLabel.Text);

            bt.PassengerUsername = usernameLabel.Text;
            bt.PassengerFullName = passengerFullNameLabel.Text;
            bt.Airplane = airplaneLabel.Text;
            bt.Source = sourceLabel.Text;
            bt.Destination = destinationLabel.Text;
            bt.Departure = departureLabel.Text;
            bt.Cost = Convert.ToInt32(costLabel.Text);
            bt.Seats = seatLabel.Text;


            if (bookRepo.Insert(bt) && bsRepo.Insert(bs))
            {
                MessageBox.Show("Ticket Booked");
                this.bookTicketTabs.SelectTab(0);
                Clear();

            }
            else
            {
                MessageBox.Show("Error adding ticket");
            }


        }

        private void button37_Click(object sender, EventArgs e)
        {
            //book ticket back btn
            Clear();

            PassengerForm pf = new PassengerForm();
            pf.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            /*if(e.RowIndex >= 0)
            {
                //MessageBox.Show("To Book a Flight Double Click please", "Book Ticket");
            }*/
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            BookTicketRepository bkRepo = new BookTicketRepository();            
            AllUsersRepository userRepo = new AllUsersRepository();

            if (e.RowIndex >= 0)
            {
                AllUsers u = userRepo.GetUserById(passId);
                
                DataGridViewRow row = bookTicketGridView.Rows[e.RowIndex];
                int x = bkRepo.TicketCount();
                int y;

                y = x + 2;

                Console.WriteLine(passId + " " + u.UserId + " " + u.UserName + " " + u.UserFullName + " - " + x);
                

                this.bookTicketTabs.SelectTab(1);
                flightIdLabel.Text = row.Cells["FlightId"].Value.ToString();
                airplaneLabel.Text = row.Cells["AirlineName"].Value.ToString();
                ticketIdLabel.Text = y.ToString();
                passengerIdLabel.Text = passId.ToString();
                passengerFullNameLabel.Text = u.UserFullName;
                usernameLabel.Text = u.UserName;
                sourceLabel.Text = row.Cells["Source"].Value.ToString();
                destinationLabel.Text = row.Cells["Destination"].Value.ToString();
                departureLabel.Text = row.Cells["Departure"].Value.ToString();
                costLabel.Text = row.Cells["Cost"].Value.ToString();
                
            }
            

        }

        public void SeatSelect(object sender, EventArgs e)
        {
            
            int sum =0;
            Button btn = (Button)sender;
            if(tmp == 0)
            {
                tmp = Convert.ToInt32(costLabel.Text);
                
            }
            
            sum = tmp;
            Console.WriteLine(tmp + " - " + costLabel.Text);
            if(seatCount < 4)
            {
                cost = cost + sum;
                seatLabel.Text = seatLabel.Text + " " + btn.Text;
                costLabel.Text = cost.ToString();
                btn.Enabled = false;
                seatCount++;
                Console.WriteLine(sum + " - " + costLabel.Text);
            }
            else
            {
                MessageBox.Show("Maximum seats Reached");
            }

            



        }

        public void Clear()
        {
            bookTicketGridView.DataSource = null;

            flightIdLabel.Text = "";
            airplaneLabel.Text = "";
            ticketIdLabel.Text = "";
            passengerIdLabel.Text = "";
            passengerFullNameLabel.Text = "";
            usernameLabel.Text = "";
            sourceLabel.Text = "";
            destinationLabel.Text = "";
            departureLabel.Text = "";
            costLabel.Text = "";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Clear();
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            /*Button btn = (Button)sender;
            BookedSeatRepository bsRepo = new BookedSeatRepository();
            int fid = Convert.ToInt32(flightIdLabel.Text);
            

            List<BookedSeats> seats = bsRepo.getBookedTicket(Convert.ToInt32(flightIdLabel.Text));

            
             if(btn.Text.Equals(seats.Any(j => j.FlightId == fid)))
             {
                btn.Enabled = false;
             }*/
            


        }
    }
}
