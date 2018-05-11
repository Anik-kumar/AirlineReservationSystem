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

namespace AirlineApplication
{
    public partial class CancelForm : Form
    {
        private int userID;

        public CancelForm()
        {
            InitializeComponent();
        }

        public CancelForm(int uid)
        {
            InitializeComponent();
            userID = uid;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //cancel ticket btn
            BookTicketRepository btRepo = new BookTicketRepository();
            int tId = Convert.ToInt32(textBox1.Text);
            
            if(btRepo.CancelTicketByPassenger(userID, tId))
            {
                MessageBox.Show("Ticket Cancel Successful.");
            }
            else
            {
                MessageBox.Show("Error In Ticket Cancel.");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            //back btn to passenger form
            textBox1.Text = "";
            PassengerForm pform = new PassengerForm();
            pform.Show();
            this.Hide();


        }
    }
}
