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
    public partial class SeatDelete : Form
    {
        private string id;
        private string name;
        public SeatDelete(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;

            SeatRepository SeatRepo = new SeatRepository();
            List<Seat> sList = SeatRepo.GetAllSeats();
            this.SeatDeleteGridView.DataSource = sList;
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Admin_Panel AP = new Admin_Panel(id,name);
            AP.Show();
            this.Hide();
        }

        private void LoadbtnClicked(object sender, EventArgs e)
        {
            SeatRepository SeatRepo = new SeatRepository();
            List<Seat> sList = SeatRepo.GetAllSeats();
            this.SeatDeleteGridView.DataSource = sList;
        }

        private void DeletebtnClicked(object sender, EventArgs e)
        {
            Seat s = new Seat();
            s.Seatid = this.Sidtbox.Text;

            SeatRepository SeatRepo = new SeatRepository();
            if (SeatRepo.SeatDelete(s.Seatid))
            {
                MessageBox.Show("Seat Information Deleted", "Delete");
            }
            else
            {
                MessageBox.Show("Can Not Delete Data", "Delete Error");
            }
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.SeatDeleteGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.Sidtbox.Text = row.Cells[0].Value.ToString();
                this.Snametbox.Text = row.Cells[1].Value.ToString();
                this.Pricetbox.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
