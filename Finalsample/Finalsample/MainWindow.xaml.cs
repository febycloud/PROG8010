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

namespace Finalsample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Name my name
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (vm.Calc())
            {
                Calcwindow cw = new Calcwindow(vm);
                cw.ShowDialog();
            }
        }
    }
}
