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
    public partial class Employee_Panel : Form
    {
        private string id;
        private string name;
        public Employee_Panel(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;
            Namelbl.Text = name;
        }
        private void LogoutClicked(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void ProfileClicked(object sender, EventArgs e)
        {
            Employee_Profile EP = new Employee_Profile(id,name);
            EP.Show();
            this.Hide();
        }

        private void TicketSellClicked(object sender, EventArgs e)
        {
            Ticket_Sell TS = new Ticket_Sell(id,name);
            TS.Show();
            this.Hide();
        }

        private void CancelReservationClicked(object sender, EventArgs e)
        {
            CancelReservation CR = new CancelReservation(id,name);
            CR.Show();
            this.Hide();
        }

        private void NoticeAddClicked(object sender, EventArgs e)
        {
            Notice_ADD NA = new Notice_ADD(id,name);
            NA.Show();
            this.Hide();
        }

        private void NoticeDeletebtnClicked(object sender, EventArgs e)
        {
            Notice_Delete ND = new Notice_Delete(id,name);
            ND.Show();
            this.Hide();
        }

        private void PassDeketeClicked(object sender, EventArgs e)
        {
            Passenger_Delete PD = new Passenger_Delete(id,name);
            PD.Show();
            this.Hide();
        }
    }
}
