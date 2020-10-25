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
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Signup S = new Signup();
            this.Hide();
            S.Show();
        }

        private void addClicked(object sender, EventArgs e)
        {
            RPassenger p = new RPassenger();
            p.Id = this.idtbox.Text;
            p.Name = this.nametbox.Text;
            p.Password = this.passtbox.Text;
            p.Dateofbirth = this.DOBtdp.Value.ToShortDateString();
            p.Gender = this.GendertBox.Text;
            p.Nationality = this.Ntbox.Text;
            p.Type= Convert.ToInt32(this.typetbox.Text);

            PassengerRepository PassRepo = new PassengerRepository();
            if (PassRepo.PassengerAdd(p))
            {
                MessageBox.Show("Passenger Information Added", "ADD");
            }
            else
            {
                MessageBox.Show("Can Not Add Data", "Insert Error");
            }
        }
    }
}
