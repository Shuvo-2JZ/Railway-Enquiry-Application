using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    public class RLogin
    {
        private string id;
        private string name;
        private string password;
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
        public int Type
        {
            set { type = value; }
            get { return type; }
        }
    }
}
