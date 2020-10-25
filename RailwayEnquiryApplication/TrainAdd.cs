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
    public partial class TrainAdd : Form
    {
        private string id;
        private string name;
        public TrainAdd(string i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Admin_Panel Ap = new Admin_Panel(id,name);
            Ap.Show();
            this.Hide();
        }

        private void AddtrainClicked(object sender, EventArgs e)
        {
            Train t = new Train();
            t.Trainid = this.Tidtbox.Text;
            t.Trainname = this.Tnametbox.Text;
            t.From = this.fromtbox.Text;
            t.To = this.totbox.Text;
            t.StartingTime = this.StimeTDP.Value.ToShortTimeString();
            t.ReachingTime = this.RTimeTDP.Value.ToShortTimeString();
            t.Noofseats= Convert.ToInt32(this.NoStbox.Text);

            TrainRepository TrainRepo = new TrainRepository();
            if (TrainRepo.TrainAdd(t))
            {
                MessageBox.Show("Train Information Added", "ADD");
            }
            else
            {
                MessageBox.Show("Can Not Add Data", "Insert Error");
            }
        }

        private void LoadbtnClicked(object sender, EventArgs e)
        {
            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.GetAllTrains();
            this.TrainGridView.DataSource = tList;
        }
    }
}
