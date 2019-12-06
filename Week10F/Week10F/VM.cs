using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10F
{
    public class VM
    {
        public BindingList<Course> Courses { get; set; } = new BindingList<Course>();

        public VM()
        {
            DB db = DB.GetInstance();
            Courses = new BindingList<Course>(db.GetCourses());

            bool worked = db.DeleteCourse(new Course { Number = "BUS9999" });
            worked = db.AddCourse(new Course { Credits = 7, FrenchName = "Parle vous", Hours = 13, Name = "Speak french good", Number="ACCT1025" });
            worked = db.AddCourse(new Course { Credits = 7, FrenchName = "Parle vous", Hours = 13, Name = "Speak french good", Number = "BUS9999" });
            worked = db.UpdateCourse(new Course { Credits = 7, FrenchName = "Parle vous", Hours = 13, Name = "Speak french well", Number = "BUS9999" });
        }
    }
}
