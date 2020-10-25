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
    public partial class SeatAdd : Form
    {
        private string id;
        private string name;
        public SeatAdd(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Admin_Panel AP = new Admin_Panel(id,name);
            AP.Show();
            this.Hide();
        }

        private void AddbtnClicked(object sender, EventArgs e)
        {
            Seat s = new Seat();
            s.Seatid = this.Sidtbox.Text;
            s.Seatname = this.Snametbox.Text;
            s.Price= Convert.ToDouble(this.Pricetbox.Text);

            SeatRepository SeatRepo = new SeatRepository();
            if (SeatRepo.SeatAdd(s))
            {
                MessageBox.Show("Seat Information Added", "ADD");
            }
            else
            {
                MessageBox.Show("Can Not Add Data", "Insert Error");
            }
        }

        private void LoadbtnClicked(object sender, EventArgs e)
        {
            SeatRepository SeatRepo = new SeatRepository();
            List<Seat> sList = SeatRepo.GetAllSeats();
            this.SeatAddGridView.DataSource = sList;
        }
    }
}
