using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RailwayEnquiryRepository
{
    public class SeatRepository
    {
        public List<Seat> GetAllSeats()
        {
            string query = "SELECT * from Seat";
            List<Seat> sList = new List<Seat>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Seat s = new Seat();
                s.Seatid = sdr["Seatid"].ToString();
                s.Seatname = sdr["Seatname"].ToString();
                s.Price = Convert.ToDouble(sdr["Price"]);

                sList.Add(s);
            }
            dcc.CloseConnection();
            return sList;
        }
        public bool SeatAdd(Seat s)
        {
            try
            {
                string query = "INSERT into Seat VALUES ('" + s.Seatid + "', '" + s.Seatname + "', " + s.Price + ")";
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
        public bool SeatDelete(string seatid)
        {
            try
            {
                string query = "DELETE From Seat WHERE Seatid='" + seatid + "'";
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
