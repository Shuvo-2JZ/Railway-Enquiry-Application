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
    public partial class CancelSchedule : Form
    {
        private string id;
        private string name;
        public CancelSchedule(string i,string n)
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

        private void LoadbtnClicked(object sender, EventArgs e)
        {
            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.GetAllTrains();
            this.CancelScheduleGridView.DataSource = tList;
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.CancelScheduleGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.Tidtbox.Text = row.Cells[0].Value.ToString();
                this.Tnametbox.Text = row.Cells[1].Value.ToString();
                this.fromtbox.Text = row.Cells[2].Value.ToString();
                this.totbox.Text = row.Cells[3].Value.ToString();
                this.Stimetbox.Text = row.Cells[4].Value.ToString();
                this.Rtimetbox.Text = row.Cells[5].Value.ToString();
                this.NoStbox.Text = row.Cells[6].Value.ToString();
            }
        }

        private void DeletebtnClicked(object sender, EventArgs e)
        {
            Train t = new Train();
            t.Trainid = this.Tidtbox.Text;
            TrainRepository TrainRepo = new TrainRepository();
            if (TrainRepo.CancelSchedule(t.Trainid))
            {
                MessageBox.Show("Train Information Deleted", "Delete");
            }
            else
            {
                MessageBox.Show("Can Not Delete Data", "Delete Error");
            }
        }
    }
}
