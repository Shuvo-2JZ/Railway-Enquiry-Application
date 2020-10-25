using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    public class RTicket
    {
        private String ticketid;
        private String journeydate;
        private String tranid;
        private string seatClassid;
        private String passsengerid;
        private String seatno;
        private double price;


        public String Ticketid
        {
            set { ticketid = value; }
            get { return ticketid; }
        }
        public String Journeydate
        {
            set { journeydate = value; }
            get { return journeydate; }
        }
        public String Tranid
        {
            set { tranid = value; }
            get { return tranid; }
        }
        public string SeatClassid

        {
            set { seatClassid = value; }
            get { return seatClassid; }
        }
        public String Passsengerid
        {
            set { passsengerid = value; }
            get { return passsengerid; }
        }
        public String Seatno
        {
            set { seatno = value; }
            get { return seatno; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
    }
}
