using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RailwayEnquiryRepository
{
    public class EmployeeRepository
    {
        public bool EmployeeAdd(REmployee e)
        {
            try
            {
                string query = "INSERT into Employee VALUES ('" + e.Id + "', '" + e.Name + "', '" + e.Designation + "', '" + e.Password + "', " + e.Salary + ", '" + e.Phoneno + "', '" + e.Email + "', " + e.Type + ")";
                string query2 = "INSERT into Login VALUES ('" + e.Id + "', '" + e.Name + "','" + e.Password + "', " + e.Type + ")";
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
        public REmployee Profile(string id)
        {
            string query = "SELECT * from Employee WHERE Id = '" + id + "'";
            REmployee e = null;
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                e = new REmployee();
                e.Id = sdr["Id"].ToString();
                e.Name = sdr["Name"].ToString();
                e.Designation = sdr["Designation"].ToString();
                e.Password = sdr["Password"].ToString();
                e.Salary = Convert.ToDouble(sdr["Salary"]);
                e.Phoneno = sdr["Phoneno"].ToString();
                e.Email = sdr["Email"].ToString();
                e.Type = Convert.ToInt32(sdr["Type"]);
            }
            dcc.CloseConnection();
            return e;
        }
        public List<REmployee> GetAllEmployees()
        {
            string query = "SELECT * from Employee";
            List<REmployee> eList = new List<REmployee>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                REmployee e = new REmployee();
                e.Id = sdr["Id"].ToString();
                e.Name = sdr["Name"].ToString();
                e.Designation = sdr["Designation"].ToString();
                //e.Password = sdr["Password"].ToString();
                e.Salary = Convert.ToDouble(sdr["Salary"]);
                e.Phoneno = sdr["Phoneno"].ToString();
                e.Email = sdr["Email"].ToString();
                //e.Type = Convert.ToInt32(sdr["Type"]);
                eList.Add(e);
            }
            dcc.CloseConnection();
            return eList;
        }
        public bool EmployeeDelete(string id)
        {
            try
            {
                string query = "DELETE From Employee WHERE Id='" + id + "'";
                string query2 = "DELETE From Login WHERE Id='" + id + "'";
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
        public bool PasswordChange(REmployee e)
        {
            try
            {
                string query = "UPDATE Employee SET Password = '" + e.Password + "'WHERE Id ='" + e.Id + "' ";
                string query1 = "UPDATE Login SET Password = '" + e.Password + "'WHERE Id ='" + e.Id + "' ";
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
