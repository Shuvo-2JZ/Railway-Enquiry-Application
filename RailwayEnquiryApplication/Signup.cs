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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void PassengerbtnClicked(object sender, EventArgs e)
        {
            Passenger P = new Passenger();
            this.Hide();
            P.Show();
        }

        private void EmployeebtnClicked(object sender, EventArgs e)
        {
            Employee E = new Employee();
            this.Hide();
            E.Show();
        }

        private void AdminbtnClicked(object sender, EventArgs e)
        {
            Admin A = new Admin();
            this.Hide();
            A.Show();
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Login L = new Login();
            this.Hide();
            L.Show();
        }
    }
}
