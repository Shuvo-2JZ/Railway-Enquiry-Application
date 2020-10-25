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
    public partial class Passenger_Panel : Form
    {
        private string id;
        private string name;
        public Passenger_Panel(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;
            Namelbl.Text = name;
        }

        private void logoutClicked(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void TrainSchedule(object sender, EventArgs e)
        {
            TrainSchedule t = new TrainSchedule(id,name);
            t.Show();
            this.Hide();
        }

        private void TicketPriceClicked(object sender, EventArgs e)
        {
            TicketPrice TP = new TicketPrice(id,name);
            TP.Show();
            this.Hide();
        }

        private void NoticeBoardClicked(object sender, EventArgs e)
        {
            NoticeInfo NN = new NoticeInfo(id,name);
            NN.Show();
            this.Hide();
        }

        private void profilebtnclicked(object sender, EventArgs e)
        {
            Passenger_Profile PP = new Passenger_Profile(id,name);
            PP.Show();
            this.Hide();
        }

        private void TrainSearchClicked(object sender, EventArgs e)
        {
            TrainSearch TS = new TrainSearch(id,name);
            TS.Show();
            this.Hide();
        }

        private void CancelReservationClicked(object sender, EventArgs e)
        {
            Cancel_Reservation CR = new Cancel_Reservation(id,name);
            CR.Show();
            this.Hide();
        }
    }
}
