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
    public partial class Passenger_Profile : Form
    {
        private string id;
        private string name;
        public Passenger_Profile(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;
            getProfile();
        }
        public void getProfile()
        {
            PassengerRepository PassRepo = new PassengerRepository();
            RPassenger p = PassRepo.Profile(id);

            this.pidtbox.Text = p.Id;
            this.pnametbox.Text = p.Name;
            this.passtbox.Text = p.Password;
            this.dateofbirthtbox.Text = p.Dateofbirth;
            this.gendertbox.Text = p.Gender;
            this.nationalitytbox.Text = p.Nationality;
            this.typetbox.Text = p.Type.ToString();
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Passenger_Panel PP = new Passenger_Panel(id,name);
            PP.Show();
            this.Hide();
        }

        private void ChangePasswordClicked(object sender, EventArgs e)
        {
            this.passtbox.Enabled = true;
            this.Confirmbtn.Enabled = true;
            this.button1.Enabled = false;
        }

        private void ConfirmClicked(object sender, EventArgs e)
        {
            RPassenger Rp = new RPassenger();
            Rp.Id = this.pidtbox.Text;
            Rp.Password = this.passtbox.Text;

            PassengerRepository PassRepo = new PassengerRepository();
            if (PassRepo.PasswordChange(Rp))
            {
                MessageBox.Show("Password Change Successfully", "Update");
                this.Confirmbtn.Enabled = false;
                this.button1.Enabled = true;
                this.passtbox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Can Not Add Data", "Update Error");
            }
        }
    }
}
