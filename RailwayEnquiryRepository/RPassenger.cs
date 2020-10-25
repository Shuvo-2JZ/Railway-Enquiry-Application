using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
     public class RPassenger
    {
        private string id;
        private string name;
        private string password;
        private string dateofbirth;
        private string gender;
        private string nationality;
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
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public string Dateofbirth
        {
            set { dateofbirth = value; }
            get { return dateofbirth; }
        }
        public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public string Nationality
        {
            set { nationality = value; }
            get { return nationality; }
        }
        public int Type
        {
            set { type = value; }
            get { return type; }
        }
    }
}
