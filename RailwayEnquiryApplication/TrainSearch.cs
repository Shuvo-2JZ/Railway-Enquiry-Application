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
    public partial class TrainSearch : Form
    {
        private string id;
        private string name;
        public TrainSearch(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;

            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.GetAllTrains();
            this.TrainSearchGridView.DataSource = tList;
        }

        private void Backbtnclicked(object sender, EventArgs e)
        {
            Passenger_Panel PP = new Passenger_Panel(id,name);
            PP.Show();
            this.Hide();
        }

        private void SearchbtnClicked(object sender, EventArgs e)
        {
            string text = this.Searchtbox.Text;
            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.SearchTrain(text);
            this.TrainSearchGridView.DataSource = tList;
        }

        private void LoadbtnClicked(object sender, EventArgs e)
        {
            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.GetAllTrains();
            this.TrainSearchGridView.DataSource = tList;
        }
    }
}
