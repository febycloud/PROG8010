using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paysorter
{
    public class VM
    {
        public BindingList<Employee> Employees { get; set; } = new BindingList<Employee>();
        DB db = DB.GetInstance();

        public VM()
        {
           
            Employees = new BindingList<Employee>(db.GetEmployeesAsc("Id"));
        }

        public void getASC(string type)
        {           
            Employees =  new BindingList<Employee>(db.GetEmployeesAsc(type));
        }

        public void getDESC(string type)
        {
            Employees = new BindingList<Employee>(db.GetEmployeesDesc(type));

        }
  


    }
}
