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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        Detail detail;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (vm.SelectProduct != null)
            {
                //if (detail == null)
                //{
                //    detail = new Detail(vm.SelectProduct);
                //    // detail.ShowDialog();//show detail window and unfunction mainwindow
                //    detail.Closed += detail_Closed;
                //    detail.Show();//show detail window but function mainwindow
                //}
                if (detail == null)
                {
                    detail = new Detail(vm);
                    // detail.ShowDialog();//show detail window and unfunction mainwindow
                    detail.Closed += detail_Closed;
                    detail.Show();//show detail window but function mainwindow
                }

            }
        }

        private void detail_Closed(object sender, EventArgs e)
        {
            detail = null;
        }
    }
}
