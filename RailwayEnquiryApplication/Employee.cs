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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Signup S = new Signup();
            this.Hide();
            S.Show();
        }

        private void AddClicked(object sender, EventArgs e)
        {
            REmployee em = new REmployee();
            em.Id = this.idtbox.Text;
            em.Name = this.nametbox.Text;
            em.Password = this.passwordtbox.Text;
            em.Designation = this.EcBox.Text;
            em.Salary= Convert.ToDouble(this.salarytbox.Text);
            em.Phoneno = this.phtbox.Text;
            em.Email = this.emailtbox.Text;
            em.Type= Convert.ToInt32(this.typetbox.Text);

            EmployeeRepository EmpRepo = new EmployeeRepository();
            if (EmpRepo.EmployeeAdd(em))
            {
                MessageBox.Show("Employee Information Added", "ADD");
            }
            else
            {
                MessageBox.Show("Can Not Add Data", "Insert Error");
            }
        }
    }
}
