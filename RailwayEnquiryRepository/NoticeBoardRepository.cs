using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RailwayEnquiryRepository
{
    public class NoticeBoardRepository
    {
        public bool NoticeAdd(Notice n)
        {
            try
            {
                string query = "INSERT into Notice VALUES ('" + n.Noticeid + "', '" + n.Noticesubject + "', '" + n.Noticedetails + "')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Notice> GetAllNotice()
        {
            string query = "SELECT * from Notice";
            List<Notice> nList = new List<Notice>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Notice n = new Notice();
                n.Noticeid = sdr["Noticeid"].ToString();
                n.Noticesubject = sdr["Noticesubject"].ToString();
                n.Noticedetails = sdr["Noticedetails"].ToString();

                nList.Add(n);
            }
            dcc.CloseConnection();
            return nList;
        }
        public bool NoticeDelete(string noticeid)
        {
            try
            {
                string query = "DELETE From Notice WHERE Noticeid='" + noticeid + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
