using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RailwayEnquiryRepository
{
    public class LoginRepository
    {
        public bool UserLoginValidation(RLogin l)
        {
            string query = "SELECT * from Login WHERE Id = '" + l.Id + "' AND Password='" + l.Password + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            // dcc.CloseConnection();
            if (sdr.Read())
            {
                l.Name= sdr["Name"].ToString();
                l.Type = Convert.ToInt32(sdr["Type"]);
                dcc.CloseConnection();
                return true;
            }
            else
            {
                dcc.CloseConnection();
                return false;
            }
        }
    }
}
