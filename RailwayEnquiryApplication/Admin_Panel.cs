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
    public partial class Admin_Panel : Form
    {
        private string id;
        private string name;
        public Admin_Panel(string i,string n)
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

        private void AprofileClicked(object sender, EventArgs e)
        {
            Profile p = new Profile(id,name);
            p.Show();
            this.Hide();
        }

        private void trainAddClicked(object sender, EventArgs e)
        {
            TrainAdd TA = new TrainAdd(id,name);
            TA.Show();
            this.Hide();

        }

        private void TrainUpdateClicked(object sender, EventArgs e)
        {
            UpdateTrain UT = new UpdateTrain(id,name);
            UT.Show();
            this.Hide();
        }

        private void CancelScheduleClicked(object sender, EventArgs e)
        {
            CancelSchedule CS = new CancelSchedule(id,name);
            CS.Show();
            this.Hide();
        }

        private void EmployeeDeleteClicked(object sender, EventArgs e)
        {
            Employee_Delete ED = new Employee_Delete(id,name);
            ED.Show();
            this.Hide();
        }

        private void SeatAddClicked(object sender, EventArgs e)
        {
            SeatAdd SA = new SeatAdd(id,name);
            SA.Show();
            this.Hide();
        }

        private void SeatDeleteClicked(object sender, EventArgs e)
        {
            SeatDelete SD = new SeatDelete(id,name);
            SD.Show();
            this.Hide();
        }
    }
}
