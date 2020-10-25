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
    public partial class UpdateTrain : Form
    {
        private string id;
        private string name;
        public UpdateTrain(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;
        }

        private void backbtnClicked(object sender, EventArgs e)
        {
            Admin_Panel AP = new Admin_Panel(id, name);
            AP.Show();
            this.Hide();
        }

        private void UdateClicked(object sender, EventArgs e)
        {
            Train t = new Train();
            t.Trainid = this.Tidtbox.Text;
            t.Trainname = this.Tnametbox.Text;
            t.From = this.textBox1.Text;
            t.To = this.textBox2.Text;
            t.StartingTime = this.StimeDTP.Value.ToShortTimeString();
            t.ReachingTime = this.RtimeDTP.Value.ToShortTimeString();
            t.Noofseats = Convert.ToInt32(this.NoStbox.Text);

            TrainRepository TrainRepo = new TrainRepository();
            if (TrainRepo.TrainUpdate(t))
            {
                MessageBox.Show("Train Information Updated", "Update");
            }
            else
            {
                MessageBox.Show("Can Not Add Data", "Update Error");
            }

        }

        private void LoadbtnClicked(object sender, EventArgs e)
        {
            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.GetAllTrains();
            this.UpdateTrainGridView.DataSource = tList;
        }

        private void cellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.UpdateTrainGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.Tidtbox.Text = row.Cells[0].Value.ToString();
                this.Tnametbox.Text = row.Cells[1].Value.ToString();
                this.textBox1.Text = row.Cells[2].Value.ToString();
                this.textBox2.Text = row.Cells[3].Value.ToString();
                this.StimeDTP.Text = row.Cells[4].Value.ToString();
                this.RtimeDTP.Text = row.Cells[5].Value.ToString();
                this.NoStbox.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
