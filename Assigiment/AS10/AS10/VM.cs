using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AS10
{
    class VM : INotifyPropertyChanged
    {
        public BindingList<Employee> EmployeesList { get; set; } = new BindingList<Employee>();
        private DB db;
        const string SELECT_CMD_TEXT_ASC = "SELECT * FROM Employee ORDER BY hourlyPayRate ASC";
        const string SELECT_CMD_TEXT_DESC = "SELECT * FROM Employee ORDER BY hourlyPayRate DESC";

        public VM()
        {
            db = DB.GetInstance();
            GetEmployeesAsc();
        }

        public void GetEmployeesAsc()
        {
            EmployeesList = new BindingList<Employee>(db.GetEmployees(SELECT_CMD_TEXT_ASC));
            notifyChange("EmployeesList");
        }

        public void GetEmployeesDesc()
        {
            EmployeesList = new BindingList<Employee>(db.GetEmployees(SELECT_CMD_TEXT_DESC));
            notifyChange("EmployeesList");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void notifyChange([CallerMemberName]string property = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

    }
}
