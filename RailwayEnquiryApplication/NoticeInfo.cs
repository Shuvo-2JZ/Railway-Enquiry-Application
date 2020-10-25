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
    public partial class NoticeInfo : Form
    {
        private string id;
        private string name;
        public NoticeInfo(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;

            NoticeBoardRepository NoticeRepo = new NoticeBoardRepository();
            List<Notice> nList = NoticeRepo.GetAllNotice();
            this.NoticedataGridView.DataSource = nList;
        }

        private void BackClicked(object sender, EventArgs e)
        {
            Passenger_Panel PP = new Passenger_Panel(id,name);
            PP.Show();
            this.Hide();
        }

        private void Cellclicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.NoticedataGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.Nidtbox.Text = row.Cells[0].Value.ToString();
                this.NSubjecttbox.Text = row.Cells[1].Value.ToString();
                this.Ndetailstbox.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
