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
    public partial class Employee_Delete : Form
    {
        private string id;
        private string name;
        public Employee_Delete(string i, string n)
        {
            InitializeComponent();
            id = i;
            name = n;

            EmployeeRepository EmpRepo = new EmployeeRepository();
            List<REmployee> eList = EmpRepo.GetAllEmployees();
            this.EmployeeInfoGridView.DataSource = eList;
        }

        private void BackbtnClicked(object sender, EventArgs e)
        {
            Admin_Panel AP = new Admin_Panel(id,name);
            AP.Show();
            this.Hide();
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.EmployeeInfoGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.Eidtbox.Text = row.Cells[0].Value.ToString();
                this.Enametbox.Text = row.Cells[1].Value.ToString();
                this.Degtbox.Text = row.Cells[2].Value.ToString();
                //this.dateofbirthtbox.Text = row.Cells[3].Value.ToString();
                this.Salarytbox.Text = row.Cells[4].Value.ToString();
                this.PNtbox.Text = row.Cells[5].Value.ToString();
                this.Emailtbox.Text = row.Cells[6].Value.ToString();
            }
        }

        private void DeletebtnClicked(object sender, EventArgs e)
        {
            REmployee emp = new REmployee();
            emp.Id = this.Eidtbox.Text;

            EmployeeRepository EmpRepo = new EmployeeRepository();
            if (EmpRepo.EmployeeDelete(emp.Id))
            {
                MessageBox.Show("Employee Information Deleted", "Delete");
            }
            else
            {
                MessageBox.Show("Can Not Delete Data", "Delete Error");
            }
        }

        private void LOadbtnClicked(object sender, EventArgs e)
        {
            EmployeeRepository EmpRepo = new EmployeeRepository();
            List<REmployee> eList = EmpRepo.GetAllEmployees();
            this.EmployeeInfoGridView.DataSource = eList;
        }
    }
}
