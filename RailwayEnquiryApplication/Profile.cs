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
    public partial class Profile : Form
    {
        private string id;
        private string name;
        public Profile(string i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;
     
            getProfile();
        }
        private void getProfile()
        {
            AdminRepository AdminRepo = new AdminRepository();
            RAdmin Ra = AdminRepo.Profile(id);

            this.idtbox.Text = Ra.Id;
            this.Nametbox.Text = Ra.Name;
            this.positiontbox.Text = Ra.Position;
            this.passtbox.Text = Ra.Password;
            this.salarytbox.Text = Ra.Salary.ToString();
            this.typetbox.Text = Ra.Type.ToString();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Admin_Panel AP = new Admin_Panel(id,name);
            AP.Show();
            this.Hide();
        }

        private void Changepassclicked(object sender, EventArgs e)
        {
            this.passtbox.Enabled = true;
            this.Confirmbtn.Enabled = true;
            this.button1.Enabled = false;    
        }

        private void ConfirmbtnClicked(object sender, EventArgs e)
        {
            RAdmin Ra = new RAdmin();
            Ra.Id = this.idtbox.Text;
            Ra.Password = this.passtbox.Text;

            AdminRepository AdminRepo = new AdminRepository();
            if (AdminRepo.PasswordChange(Ra))
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
