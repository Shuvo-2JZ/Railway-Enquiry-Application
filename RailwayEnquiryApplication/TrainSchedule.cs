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
    public partial class TrainSchedule : Form
    {
        private string id;
        private string name;
        public TrainSchedule(string i,String n)
        {
            InitializeComponent();
            id = i;
            name = n;
            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.GetAllTrains();
            this.TraindataGridView.DataSource = tList;
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Passenger_Panel PP = new Passenger_Panel(id,name);
            PP.Show();
            this.Hide();
        }
    }
}
