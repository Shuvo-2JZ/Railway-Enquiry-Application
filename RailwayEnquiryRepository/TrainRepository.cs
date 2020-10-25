using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RailwayEnquiryRepository
{
    public class TrainRepository
    {
        public bool TrainAdd(Train t)
        {
            try
            {
                string query = "INSERT into Train VALUES ('"+t.Trainid+"', '"+t.Trainname +"', '"+t.From+"', '"+t.To+"', '"+t.StartingTime +"', '"+ t.ReachingTime +"', "+t.Noofseats+")";
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
        public List<Train> GetAllTrains()
        {
            string query = "SELECT * from Train";
            List<Train> tList = new List<Train>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Train t = new Train();
                t.Trainid = sdr["Trainid"].ToString();
                t.Trainname = sdr["Trainname"].ToString();
                t.From = sdr["StartingPoint"].ToString();
                t.To = sdr["Destination"].ToString();
                t.StartingTime = sdr["StartingTime"].ToString();
                t.ReachingTime = sdr["ReachingTime"].ToString();
                t.Noofseats = Convert.ToInt32(sdr["Noofseats"]);

                tList.Add(t);
            }
            dcc.CloseConnection();
            return tList;
        }
        public bool TrainUpdate(Train t)
        {
            try
            {
                string query = "UPDATE Train SET Trainname = '" + t.Trainname+ "', StartingPoint ='" + t.From + "', Destination ='" + t.To + "', StartingTime ='" + t.StartingTime+"', ReachingTime ='"+t.ReachingTime+ "', Noofseats = " + t.Noofseats+ "WHERE Trainid ='"+t.Trainid+"' ";
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
        public bool CancelSchedule(string trainid)
        {
            try
            {
                string query = "DELETE From Train WHERE Trainid='" + trainid + "'";
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
        public Train TrainSearch(string trainid)
        {
            string query = "SELECT * from Train WHERE Trainid = '" + trainid + "'";
            Train t = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                t = new Train();
                t.Trainid = sdr["Trainid"].ToString();
                t.Trainname = sdr["Trainname"].ToString();
                t.From = sdr["StartingPoint"].ToString();
                t.To = sdr["Destination"].ToString();
                t.StartingTime = sdr["StartingTime"].ToString();
                t.ReachingTime = sdr["ReachingTime"].ToString();
                t.Noofseats = Convert.ToInt32(sdr["Noofseats"]);
            }
            dcc.CloseConnection();
            return t;
        }
        public List<Train> SearchTrain(string text)
        {
            string query = "SELECT * from Train Where Trainid like'%"+ text +"%' or Trainname like'%"+ text + "%' or StartingPoint like'%" + text + "%' or Destination like'%" + text + "%'";
            List<Train> tList = new List<Train>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Train t = new Train();
                t.Trainid = sdr["Trainid"].ToString();
                t.Trainname = sdr["Trainname"].ToString();
                t.From = sdr["StartingPoint"].ToString();
                t.To = sdr["Destination"].ToString();
                t.StartingTime = sdr["StartingTime"].ToString();
                t.ReachingTime = sdr["ReachingTime"].ToString();
                t.Noofseats = Convert.ToInt32(sdr["Noofseats"]);

                tList.Add(t);
            }
            dcc.CloseConnection();
            return tList;
        }

    }
}
