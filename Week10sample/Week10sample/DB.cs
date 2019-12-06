using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10sample
{
    public class DB
    {
      
        const string CONNECT_STRING = "Server=.\\SQLEXPRESS;Database=SIS;Trusted_Connection=True;";//www.connectionstrings.com/sql-server/
        const string SELECT_CMD_TEXT = "select* from Course";
        const string UPDATE_CMD_TEXT = "UPDATE Course SET hours=@HOURS,credits=@CREDITS,name=@NAME,frenchName=@FRENCHNAME WHERE number=@NUMBER";
        const string DELETE_CMD_TEXT = "delete from Course where number=@NUMBER";
        const string VALIDATE_CMD_TEXT = "select count(*) from Course where number=@NUMBER";
        const string INSERT_CMD_TEXT = "insert into Course(number,hours,credits,name,frenchName) values(@NUMBER,@@HOURS,@CREDITS,@NAME,@FRENCHNAME)";
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

        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();
            SqlCommand cmd = new SqlCommand(SELECT_CMD_TEXT, connection);
            SqlDataReader dr = cmd.ExecuteReader();//using when sql SELECT query
            while (dr.Read())
            {
                courses.Add(new Course
                {
                    Credits = dr.GetInt32(dr.GetOrdinal("credits")),
                    FrenchName = dr.GetString(dr.GetOrdinal("frenchName")),
                    Hours = dr.GetInt32(dr.GetOrdinal("hours")),
                    Name = dr.GetString(dr.GetOrdinal("name")),
                    Number = dr.GetString(dr.GetOrdinal("number"))
                });
            }
            dr.Close();
            return courses;
        }

        public bool UpdateCourse(Course c)
        {
            bool done = false;
            SqlCommand cmd = new SqlCommand( UPDATE_CMD_TEXT, connection);
            cmd.Parameters.AddWithValue("@HOURS", c.Hours);
            cmd.Parameters.AddWithValue("@CREDITS", c.Credits);
            cmd.Parameters.AddWithValue("@NAME", c.Name);
            cmd.Parameters.AddWithValue("@FRENCHNAME", c.FrenchName);
            cmd.Parameters.AddWithValue("@NUMBER", c.Number);
            int count = cmd.ExecuteNonQuery();
            done = count > 0;
            return done;
        }

        public bool DeleteCourse(Course c)
        {
            bool done = false;
            SqlCommand cmd = new SqlCommand(DELETE_CMD_TEXT, connection);
            cmd.Parameters.AddWithValue("@NUMBER", c.Number);
            int count = cmd.ExecuteNonQuery();

            done = count > 0;
            return done;
        }
        public bool AddCourse(Course c)
        {

            bool done = false;
            try
            {
                SqlCommand cmdV = new SqlCommand(VALIDATE_CMD_TEXT, connection);
                cmdV.Parameters.AddWithValue("@NUMBER", c.Number);
                int existRows = (int)cmdV.ExecuteScalar();
                if (existRows == 0)
                {
                    SqlCommand cmdI = new SqlCommand(INSERT_CMD_TEXT, connection);
                    cmdI.Parameters.AddWithValue("@HOURS", c.Hours);
                    cmdI.Parameters.AddWithValue("@CREDITS", c.Credits);
                    cmdI.Parameters.AddWithValue("@NAME", c.Name);
                    cmdI.Parameters.AddWithValue("@FRENCHNAME", c.FrenchName);
                    cmdI.Parameters.AddWithValue("@NUMBER", c.Number);
                    int count = cmdI.ExecuteNonQuery();
                    done = count > 0;
                }
            }
            catch { }

                return done;

            
            }
       


    }
}
