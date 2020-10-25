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
    public partial class Employee_Profile : Form
    {
        private string id;
        private string name;
        public Employee_Profile(string i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;
            getProfile();
        }
        private void getProfile()
        {
            EmployeeRepository EmpRepo = new EmployeeRepository();
            REmployee e = EmpRepo.Profile(id);

            this.Eidtbox.Text = e.Id;
            this.Enametbox.Text = e.Name;
            this.Epasstbox.Text = e.Password;
            this.Degtbox.Text = e.Designation;
            this.Salarytbox.Text = e.Salary.ToString();
            this.PNtbox.Text = e.Phoneno;
            this.Emailtbox.Text = e.Email;
            this.typetbox.Text = e.Type.ToString();
        }

        private void Backbtnclicked(object sender, EventArgs e)
        {
            Employee_Panel EP = new Employee_Panel(id,name);
            EP.Show();
            this.Hide();
        }

        private void ChangePasswordClicked(object sender, EventArgs e)
        {
            this.Epasstbox.Enabled = true;
            this.Confirmbtn.Enabled = true;
            this.button1.Enabled = false;
        }

        private void ConfirmbtnClicked(object sender, EventArgs e)
        {
            REmployee Re = new REmployee();
            Re.Id = this.Eidtbox.Text;
            Re.Password = this.Epasstbox.Text;

            EmployeeRepository EmpRepo = new EmployeeRepository();
            if (EmpRepo.PasswordChange(Re))
            {
                MessageBox.Show("Password Change Successfully", "Update");
                this.Confirmbtn.Enabled = false;
                this.button1.Enabled = true;
                this.Epasstbox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Can Not Add Data", "Update Error");
            }
        }
    }
}
