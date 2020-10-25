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
    public partial class TicketPrice : Form
    {
        private string id;
        private string name;
        public TicketPrice(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;
            SeatRepository SeatRepo = new SeatRepository();
            List<Seat> sList = SeatRepo.GetAllSeats();
            this.PricedataGridView.DataSource = sList;

        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Passenger_Panel PP = new Passenger_Panel(id, name);
            PP.Show();
            this.Hide();
        }

        private void SearchSeatPriceClicked(object sender, EventArgs e)
        {
            string text = this.Searchtbox.Text;
            TicketRepository TicketRepo = new TicketRepository();
            List<Seat> sList = TicketRepo.SearchSeatPrice(text);
            this.PricedataGridView.DataSource = sList;
        }
    }
}
