using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AS10
{
    class DB
    {
        const string CONNECT_STRING = "Server=.\\SQLEXPRESS;Database=Personnel;Trusted_Connection=True;";
        static DB db;

        SqlConnection conn;

        public static DB GetInstance()
        {
            if (db == null)
                db = new DB();

            return db;
        }

        private DB()
        {
            conn = new SqlConnection(CONNECT_STRING);
            conn.Open();
        }

        public List<Employee> GetEmployees(string order)
        {
            List<Employee> employees = new List<Employee>();

            SqlCommand cmd = new SqlCommand(order, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                employees.Add(new Employee
                {
                    ID = dr.GetInt32(dr.GetOrdinal("ID")),
                    FirstName = dr.GetString(dr.GetOrdinal("FirstName")),
                    LastName = dr.GetString(dr.GetOrdinal("LastName")),
                    Position = dr.GetString(dr.GetOrdinal("Position")),
                    HourlyPayRate = dr.GetDecimal(dr.GetOrdinal("HourlyPayRate"))
                });
            }
            dr.Close();

            return employees;
        }
    }
}
