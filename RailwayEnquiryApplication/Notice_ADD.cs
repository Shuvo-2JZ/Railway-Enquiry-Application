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
    public partial class Notice_ADD : Form
    {
        private string id;
        private string name;
        public Notice_ADD(string i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Employee_Panel EP = new Employee_Panel(id,name);
            EP.Show();
            this.Hide();
        }

        private void NoticeAssClicked(object sender, EventArgs e)
        {
            Notice n = new Notice();
            n.Noticeid = this.Nidtbox.Text;
            n.Noticesubject = this.NoticeSubjecttbox.Text;
            n.Noticedetails = this.Ndetailstbox.Text;

            NoticeBoardRepository NBRepo = new NoticeBoardRepository();
            if (NBRepo.NoticeAdd(n))
            {
                MessageBox.Show("Notice Information Added", "ADD");
            }
            else
            {
                MessageBox.Show("Can Not Add Data", "Insert Error");
            }


        }
    }
}
