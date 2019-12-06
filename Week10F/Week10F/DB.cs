using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10F
{
    public class DB
    {
        const string CONNECT_STRING = "Server=.\\SQLEXPRESS;Database=SIS;Trusted_Connection=True;";
        const string SELECT_CMD_TEXT = "SELECT * FROM Course";
        const string UPDATE_CMD_TEXT = "UPDATE Course SET hours=@HOURS,credits=@CREDITS,name=@NAME,frenchName=@FRNAME WHERE number=@NUMBER";
        const string DELETE_CMD_TEXT = "DELETE FROM Course WHERE number=@NUMBER";
        const string VALIDATE_CMD_TEXT = "SELECT COUNT(*) FROM Course WHERE number=@NUMBER";
        const string INSERT_CMD_TEXT = "INSERT INTO Course (number,hours,credits,name,frenchName) VALUES (@NUMBER,@HOURS,@CREDITS,@NAME,@FRNAME)";
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

        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();

            SqlCommand cmd = new SqlCommand(SELECT_CMD_TEXT, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                courses.Add(new Course
                {
                    Credits = dr.GetInt32(dr.GetOrdinal("Credits")),
                    FrenchName = dr.GetString(dr.GetOrdinal("FrenchName")),
                    Hours = dr.GetInt32(dr.GetOrdinal("Hours")),
                    Name = dr.GetString(dr.GetOrdinal("Name")),
                    Number = dr.GetString(dr.GetOrdinal("Number"))
                });
            }
            dr.Close();

            return courses;
        }

        public bool UpdateCourse(Course c)
        {
            SqlCommand cmd = new SqlCommand(UPDATE_CMD_TEXT, conn);
            cmd.Parameters.AddWithValue("@HOURS", c.Hours);
            cmd.Parameters.AddWithValue("@CREDITS", c.Credits);
            cmd.Parameters.AddWithValue("@NAME", c.Name);
            cmd.Parameters.AddWithValue("@FRNAME", c.FrenchName);
            cmd.Parameters.AddWithValue("@NUMBER", c.Number);
            int count = cmd.ExecuteNonQuery();

            return count > 0;
        }

        public bool DeleteCourse(Course c)
        {
            SqlCommand cmd = new SqlCommand(DELETE_CMD_TEXT, conn);
            cmd.Parameters.AddWithValue("@NUMBER", c.Number);
            int count = cmd.ExecuteNonQuery();

            return count > 0;
        }

        public bool AddCourse(Course c)
        {
            bool success = false;

            try
            {
                SqlCommand cmdV = new SqlCommand(VALIDATE_CMD_TEXT, conn);
                cmdV.Parameters.AddWithValue("@NUMBER", c.Number);
                int existingRows = (int)cmdV.ExecuteScalar();

                if (existingRows == 0)
                {
                    SqlCommand cmdI = new SqlCommand(INSERT_CMD_TEXT, conn);
                    cmdI.Parameters.AddWithValue("@HOURS", c.Hours);
                    cmdI.Parameters.AddWithValue("@CREDITS", c.Credits);
                    cmdI.Parameters.AddWithValue("@NAME", c.Name);
                    cmdI.Parameters.AddWithValue("@FRNAME", c.FrenchName);
                    cmdI.Parameters.AddWithValue("@NUMBER", c.Number);
                    int count = cmdI.ExecuteNonQuery();

                    success = count > 0;
                }
            }
            catch { }

            return success;
        }
    }
}
