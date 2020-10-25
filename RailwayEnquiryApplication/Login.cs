using RailwayEnquiryRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayEnquiryApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private void SignUpbtnClicked(object sender, EventArgs e)
        {
            Signup SU = new Signup();
            SU.Show();
            this.Hide();
        }

        private void ExitbtnClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            RLogin l = new RLogin();
            l.Id = this.UidtBox.Text;
            l.Password = this.UpasstBox.Text;

            LoginRepository LoginRepo = new LoginRepository();
            if (LoginRepo.UserLoginValidation(l))
            {
                if(l.Type==1)
                {
                    string id = l.Id;
                    string name = l.Name;
                    Admin_Panel AP = new Admin_Panel(id,name);
                    AP.Show();
                    this.Hide();
                }
                else if(l.Type==2)
                {
                    string id = l.Id;
                    string name = l.Name;
                    Employee_Panel EP = new Employee_Panel(id, name);
                    EP.Show();
                    this.Hide();
                }
                else if(l.Type==3)
                {
                    string id = l.Id;
                    string name = l.Name;

                    Passenger_Panel PP = new Passenger_Panel(id, name);
                    PP.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Id or Password", "Login Failed");
            }
        }
    }
}
