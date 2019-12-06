using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Paysorter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ASCDESC.SelectedValue.ToString() == "ASC")
            {
                myListbox.ItemsSource = null;
                vm.getASC(myType.SelectedValue.ToString());
                myListbox.ItemsSource = vm.Employees;
                myListbox.Items.Refresh();
            }
            else
            {
                myListbox.ItemsSource = null;
                vm.getDESC(myType.SelectedValue.ToString());
                myListbox.ItemsSource = vm.Employees;
                myListbox.Items.Refresh();
            }
        }
    }
}
