using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
   public class Notice
    {
        private string noticeid;
        private string noticesubject;
        private string noticedetails;

        public string Noticeid
        {
            set { noticeid = value; }
            get { return noticeid; }
        }
        public string Noticesubject
        {
            set { noticesubject = value; }
            get { return noticesubject; }
        }
        public string Noticedetails
        {
            set { noticedetails = value; }
            get { return noticedetails; }
        }
    }
}
