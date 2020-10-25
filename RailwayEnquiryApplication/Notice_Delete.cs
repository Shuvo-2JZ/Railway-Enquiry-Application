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
    public partial class Notice_Delete : Form
    {
        private string id;
        private string name;
        public Notice_Delete(string i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;

            NoticeBoardRepository NoticeRepo = new NoticeBoardRepository();
            List<Notice> nList = NoticeRepo.GetAllNotice();
            this.NoticedataGridView.DataSource = nList;

        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Employee_Panel EP = new Employee_Panel(id, name);
            EP.Show();
            this.Hide();
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
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

        private void DeletebtnClicked(object sender, EventArgs e)
        {
            Notice n = new Notice();
            n.Noticeid = this.Nidtbox.Text;
            NoticeBoardRepository NoticeRepo = new NoticeBoardRepository();
            if (NoticeRepo.NoticeDelete(n.Noticeid))
            {
                MessageBox.Show("Notice Information Deleted", "Delete");
            }
            else
            {
                MessageBox.Show("Can Not Delete Data", "Delete Error");
            }
        }

        private void LoadbtnClicked(object sender, EventArgs e)
        {
            NoticeBoardRepository NoticeRepo = new NoticeBoardRepository();
            List<Notice> nList = NoticeRepo.GetAllNotice();
            this.NoticedataGridView.DataSource = nList;
        }
    }
}
