using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RailwayEnquiryRepository
{
    public class PassengerRepository
    {
        public bool PassengerAdd(RPassenger p)
        {
            try
            {
                string query = "INSERT into Passenger VALUES ('" + p.Id + "', '" + p.Name + "', '" + p.Password + "', '" + p.Dateofbirth + "', '" + p.Gender + "', '" + p.Nationality + "', " + p.Type + ")";
                string query2 = "INSERT into Login VALUES ('" + p.Id + "','" + p.Name + "',  '" + p.Password + "', " + p.Type + ")";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                int y = dcc.ExecuteSQL(query2);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<RPassenger> SearchPassenger(string text)
        {
            string query = "SELECT * from Passenger Where Id like'%" + text + "%' or Name like'%" + text + "%' or Dateofbirth like'%" + text + "%' or Nationality like'%" + text + "%'";
            List<RPassenger> plist = new List<RPassenger>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                RPassenger p = new RPassenger();
                p.Id = sdr["Id"].ToString();
                p.Name = sdr["Name"].ToString();
                //p.Password = sdr[""].ToString();
                p.Dateofbirth = sdr["DateOfbirth"].ToString();
                p.Gender = sdr["Gender"].ToString();
                p.Nationality = sdr["Nationality"].ToString();
                plist.Add(p);
            }
            dcc.CloseConnection();
            return plist;
        }
        public List<RPassenger> GetAllPassengers()
        {
            string query = "SELECT * from Passenger";
            List<RPassenger> pList = new List<RPassenger>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                RPassenger p = new RPassenger();
                p.Id = sdr["Id"].ToString();
                p.Name = sdr["Name"].ToString();
                //p.Password = sdr[""].ToString();
                p.Dateofbirth = sdr["DateOfbirth"].ToString();
                p.Gender = sdr["Gender"].ToString();
                p.Nationality = sdr["Nationality"].ToString();
                pList.Add(p);
            }
            dcc.CloseConnection();
            return pList;
        }
        public RPassenger Profile(string id)
        {
            string query = "SELECT * from Passenger WHERE Id = '" + id + "'";
            RPassenger p = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                p = new RPassenger();
                p.Id = sdr["Id"].ToString();
                p.Name = sdr["Name"].ToString();
                p.Dateofbirth = sdr["Dateofbirth"].ToString();
                p.Password = sdr["Password"].ToString();
                p.Gender = sdr["Gender"].ToString();
                p.Nationality = sdr["Nationality"].ToString();
                p.Type = Convert.ToInt32(sdr["Type"]);
            }
            dcc.CloseConnection();
            return p;
        }
        public List<RTicket> GetPassengerTicket(string id)
        {
            string query = "SELECT * from Ticket WHERE Passsengerid = '" + id + "'";
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
        public bool PassengerDelete(string id)
        {
            try
            {
                string query = "DELETE From Passenger WHERE Id='" + id + "'";
                string query2 = "DELETE From Ticket WHERE Passsengerid='" + id + "'";
                string query3 = "DELETE From Login WHERE Id='" + id + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                int y= dcc.ExecuteSQL(query2);
                int z= dcc.ExecuteSQL(query3);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool PasswordChange(RPassenger p)
        {
            try
            {
                string query = "UPDATE Passenger SET Password = '" + p.Password + "'WHERE Id ='" + p.Id + "' ";
                string query1 = "UPDATE Login SET Password = '" + p.Password + "'WHERE Id ='" + p.Id + "' ";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                int y = dcc.ExecuteSQL(query1);
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
