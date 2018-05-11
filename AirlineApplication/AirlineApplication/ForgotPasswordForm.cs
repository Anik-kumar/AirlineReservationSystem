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
    public partial class ForgotPasswordForm : Form
    {

        private string ans;
        private string id;

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //forgot pass submit btn
            id = this.textBox1.Text;
            ans = this.textBox2.Text;
            DatabaseConnection dt = new DatabaseConnection();
            PassengerRepository pRepo = new PassengerRepository();
            string query = "SELECT * from Passengers WHERE UserName = '" + id + "' and Question = '" + ans + "'";
            DataTable tbl = new DataTable();
            tbl = dt.dbConnect(query);


            EmployeeRepository rRepo = new EmployeeRepository();
            string query2 = "SELECT * from Employee WHERE Username = '" + id + "' and Question = '" + ans + "'";
            DataTable tbl2 = new DataTable();
            tbl2 = dt.dbConnect(query);

            AdminRepository aRepo = new AdminRepository();
            string query3 = "SELECT * from Admin WHERE Username = '" + id + "' and Question = '" + ans + "'";
            DataTable tbl3 = new DataTable();
            tbl3 = dt.dbConnect(query);

            for (int i=0; i<tbl.Rows.Count; i++)
            {
                for (int j = 0; j < tbl.Columns.Count; j++)
                    Console.WriteLine(tbl.Rows[i][j]);
            }

            if (tbl.Rows.Count == 1)
            {

                //Console.WriteLine("a");
                textBox3.Text = Convert.ToString(tbl.Rows[0]["Password"]);
                                
            }
            else if(tbl2.Rows.Count == 1)
            {
                textBox3.Text = Convert.ToString(tbl2.Rows[0]["Password"]);
                
            }
            else if (tbl3.Rows.Count == 1)
            {
                textBox3.Text = Convert.ToString(tbl3.Rows[0]["Password"]);

            }
            else
            {

                textBox3.Text = "Wrong ID or Movie";
                textBox1.Text = "";
                textBox2.Text = "";
                
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }
    }
}
