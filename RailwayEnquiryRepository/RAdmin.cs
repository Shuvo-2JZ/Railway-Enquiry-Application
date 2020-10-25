using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    public class RAdmin
    {
        private string id;
        private string name;
        private string position;
        private string password;
        private double salary;
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
        public string Position
        {
            set { position = value; }
            get { return position; }

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
        public int Type
        {
            set { type = value; }
            get { return type; }
        }
    }
}
