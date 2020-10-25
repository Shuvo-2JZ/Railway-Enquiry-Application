using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RailwayEnquiryRepository
{
    public class AdminRepository
    {
        public bool AdminAdd(RAdmin a)
        {
            try
            {
                string query = "INSERT into Admin VALUES ('" + a.Id + "', '" + a.Name + "', '" + a.Position + "', '" + a.Password + "', " + a.Salary + ", " +a.Type + ")";
                string query2= "INSERT into Login VALUES ('" + a.Id + "', '" + a.Name + "','" + a.Password + "', " + a.Type + ")";
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
        public RAdmin Profile(string id)
        {
            string query = "SELECT * from Admin WHERE Id = '" + id + "'";
            RAdmin a = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query); 

            if (sdr.Read())
            {
                a = new RAdmin();
                a.Id = sdr["Id"].ToString();
                a.Name = sdr["Name"].ToString();
                a.Position = sdr["Position"].ToString();
                a.Password = sdr["Password"].ToString();
                a.Salary = Convert.ToDouble(sdr["Salary"]);
                a.Type = Convert.ToInt32(sdr["Type"]);
            }
            dcc.CloseConnection();
            return a;
        }
        public bool PasswordChange(RAdmin a)
        {
            try
            {
                string query = "UPDATE Admin SET Password = '" +a.Password + "'WHERE Id ='" + a.Id + "' ";
                string query1 = "UPDATE Login SET Password = '" + a.Password + "'WHERE Id ='" + a.Id + "' ";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                int y= dcc.ExecuteSQL(query1);
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
