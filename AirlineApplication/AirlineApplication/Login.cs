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
    public partial class LoginForm : Form
    {
        int userId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUpForm sign = new SignUpForm();

            sign.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHomeForm admin = new AdminHomeForm();

            admin.Show();
            this.Hide();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string uname = this.userTextBox1.Text;
            string upass = this.passTextBox2.Text;
            //Console.WriteLine("user: " + uname);
            //Console.WriteLine("pass: " + upass);
                      
            AllUsersRepository userRepo = new AllUsersRepository();
            List<AllUsers> userList = userRepo.GetAllUsers();
            DatabaseConnection dt = new DatabaseConnection();

                        
            string query = "SELECT * from AllUsers WHERE Username = '" + uname + "' and Password = '" + upass + "'";
            DataTable tbl = dt.dbConnect(query);
            string designation = "";
            try
            {
                userId = Convert.ToInt32(tbl.Rows[0]["UserId"]);
                designation = tbl.Rows[0]["UserType"].ToString();

            }catch(Exception er)
            {
                MessageBox.Show("Wrong Password or Username");
            }
            //Console.WriteLine(designation);

            if (tbl.Rows.Count == 1)
            {
                if (designation.Equals("Admin"))
                {
                    AdminHomeForm aform = new AdminHomeForm(userId);
                    aform.Show();
                    this.Hide();
                }else if (designation.Equals("Employee"))
                {
                    EmployeeForm aform = new EmployeeForm(userId);
                    aform.Show();
                    this.Hide();
                }else if (designation.Equals("Passenger"))
                {
                    PassengerForm aform = new PassengerForm(userId);
                    aform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unknown User");
                }


            }
            else
            {
                passWLabel.Text = "Wrong User or Password.";
                userTextBox1.Clear();
                passTextBox2.Clear();
            }

            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PassengerForm pform = new PassengerForm();
            pform.Show();
            this.Hide();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
            this.Hide();
        }

        private void forgotPassBtn_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm fpForm = new ForgotPasswordForm();
            fpForm.Show();
            this.Hide();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
