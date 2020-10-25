using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    public class Train
    {
        private string trainid;
        private string trainname;
        private string from;
        private string to;
        private string startingTime;
        private string reachingTime;
        private int noOfSeats;

        public string Trainid
        {
            set { trainid = value; }
            get { return trainid; }
        }
        public string Trainname
        {
            set { trainname = value; }
            get { return trainname; }
        }
        public string From
        {
            set { from = value; }
            get { return from; }
        }
        public string To
        {
            set { to = value; }
            get { return to; }
        }
        public string StartingTime
        {
            set { startingTime = value; }
            get { return startingTime; }
        }
        public string ReachingTime
        {
            set { reachingTime = value; }
            get { return reachingTime; }
        }
        public int Noofseats
        {
            set { noOfSeats = value; }
            get { return noOfSeats; }
        }
    }
}
