using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    public class Seat
    {
        private string seatid;
        private string seatname;
        private double price;


        public string Seatid
        {
            set { seatid = value; }
            get { return seatid; }
        }
        public string Seatname
        {
            set { seatname = value; }
            get { return seatname; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }
}
