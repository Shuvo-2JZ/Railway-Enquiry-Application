using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    public class REmployee
    {
        private string id;
        private string name;
        private string designation;
        private string password;
        private double salary;
        private string phoneno;
        private string email;
        private int type;

        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Designation
        {
            set { designation = value; }
            get { return designation; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public string Phoneno
        {
            set { phoneno = value; }
            get { return phoneno; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        public int Type
        {
            set { type = value; }
            get { return type; }
        }
    }
}
