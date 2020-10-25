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
    public partial class Passenger_Delete : Form
    {
        private string id;
        private string name;
        public Passenger_Delete(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;

            PassengerRepository PassRepo = new PassengerRepository();
            List<RPassenger> pList = PassRepo.GetAllPassengers();
            this.PassengerInfoGridView.DataSource = pList;
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Employee_Panel EP = new Employee_Panel(id,name);
            EP.Show();
            this.Hide();
        }

        private void LoadbtnClicked(object sender, EventArgs e)
        {
            PassengerRepository PassRepo = new PassengerRepository();
            List<RPassenger> pList = PassRepo.GetAllPassengers();
            this.PassengerInfoGridView.DataSource = pList;
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.PassengerInfoGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.pidtbox.Text = row.Cells[0].Value.ToString();
                this.pnametbox.Text = row.Cells[1].Value.ToString();
                //this.Fromtbox.Text = row.Cells[2].Value.ToString();
                this.dateofbirthtbox.Text = row.Cells[3].Value.ToString();
                this.gendertbox.Text = row.Cells[4].Value.ToString();
                this.nationalitytbox.Text = row.Cells[5].Value.ToString();
                //this.NoStbox.Text = row.Cells[6].Value.ToString();
            }
        }

        private void DeletbtnClicked(object sender, EventArgs e)
        {
            RPassenger p = new RPassenger();
            p.Id = this.pidtbox.Text;

            PassengerRepository Passrepo = new PassengerRepository();
            if (Passrepo.PassengerDelete(p.Id))
            {
                MessageBox.Show("Passenger Information Deleted", "Delete");
            }
            else
            {
                MessageBox.Show("Can Not Delete Data", "Delete Error");
            }
        }
    }
}
