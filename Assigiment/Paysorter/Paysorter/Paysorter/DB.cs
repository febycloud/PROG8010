using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paysorter
{
    public class DB
    {

        const string CONNECT_STRING = "Server=.\\SQLEXPRESS;Database=Personnel;Trusted_Connection=True;";//www.connectionstrings.com/sql-server/

        static DB db;
        SqlConnection connection;
        //creat a class let everybody access
        public static DB GetInstance()
        {
            if (db == null)
                db = new DB();
            return db;
        }
        //creat a class connect to DB
        private DB()
        {
            //build connection
            connection = new SqlConnection(CONNECT_STRING);
            connection.Open();
        }

        public List<Employee> GetEmployeesAsc(string ordertype)
        {
            List<Employee> employees = new List<Employee>();
            string SELECT_CMD_TEXT = "select* from Employee order by "+ordertype+" ASC";
            SqlCommand cmd = new SqlCommand(SELECT_CMD_TEXT, connection);
            SqlDataReader dr = cmd.ExecuteReader();//using when sql SELECT query
            while (dr.Read())
            {
                employees.Add(new Employee
                {
                    Id = dr.GetInt32(dr.GetOrdinal("Id")),
                    Name = dr.GetString(dr.GetOrdinal("Name")),
                    Position = dr.GetString(dr.GetOrdinal("Position")),
                    Hourlypayrate = dr.GetInt32(dr.GetOrdinal("HourlyPayRate")),
                });
            }
            dr.Close();
            return employees;
        }



        public List<Employee> GetEmployeesDesc(string ordertype)
        {
            List<Employee> employees = new List<Employee>();
            string SELECT_CMD_TEXT = "select* from Employee order by " + ordertype + " DESC";
            SqlCommand cmd = new SqlCommand(SELECT_CMD_TEXT, connection);
            SqlDataReader dr = cmd.ExecuteReader();//using when sql SELECT query
            while (dr.Read())
            {
                employees.Add(new Employee
                {
                    Id = dr.GetInt32(dr.GetOrdinal("Id")),
                    Name = dr.GetString(dr.GetOrdinal("Name")),
                    Position = dr.GetString(dr.GetOrdinal("Position")),
                    Hourlypayrate = dr.GetInt32(dr.GetOrdinal("HourlyPayRate")),
                });
            }
            dr.Close();
            return employees;
        }

    }
}

