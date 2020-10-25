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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Signup S = new Signup();
            this.Hide();
            S.Show();
        }

        private void AddClicked(object sender, EventArgs e)
        {
            RAdmin a = new RAdmin();
            a.Id = this.idtbox.Text;
            a.Name = this.nametbox.Text;
            a.Position = this.positionCbox.Text;
            a.Password = this.passtbox.Text;
            a.Salary= Convert.ToDouble(this.salarytbox.Text);
            a.Type= Convert.ToInt32(this.typetbox.Text);

            AdminRepository adminRepo = new AdminRepository();
            if (adminRepo.AdminAdd(a))
            {
                MessageBox.Show("Admin Information Added", "ADD");
            }
            else
            {
                MessageBox.Show("Can Not Add Data", "Insert Error");
            }
        }
    }
}
