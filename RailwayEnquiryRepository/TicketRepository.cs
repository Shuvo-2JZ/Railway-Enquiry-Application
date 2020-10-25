using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RailwayEnquiryRepository
{
    public class TicketRepository
    {
        public bool TicketSell(RTicket t)
        {
            try
            {
                string query = "INSERT into Ticket VALUES ('" + t.Ticketid + "', '" + t.Journeydate + "', '" + t.Tranid + "', '" + t.SeatClassid + "', '" + t.Passsengerid + "', '" + t.Seatno + "', " + t.Price + ")";
                
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
        public List<RTicket> GetAllTicket()
        {
            string query = "SELECT * from Ticket";
            List<RTicket> tList = new List<RTicket>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                RTicket t = new RTicket();
                t.Ticketid = sdr["Ticketid"].ToString();
                t.Journeydate = sdr["Journeydate"].ToString();
                t.Tranid = sdr["Trainid"].ToString();
                t.SeatClassid = sdr["SeatClassid"].ToString();
                t.Passsengerid = sdr["Passsengerid"].ToString();
                t.Seatno = sdr["Seatno"].ToString();
                t.Price = Convert.ToDouble(sdr["Price"]); ;

                tList.Add(t);
            }
            dcc.CloseConnection();
            return tList;
        }
        public bool CancelReservation(string ticketid)
        {
            try
            {
                string query = "DELETE From Ticket WHERE Ticketid='" + ticketid + "'";
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
        public List<Seat> SearchSeatPrice(string text)
        {
            
            string query = "SELECT * from Seat Where Seatid like'%" + text + "%' or Seatname like'%" + text + "%'"; //or Price like %" + Convert.ToDouble(text) + "%";
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
    }
}
