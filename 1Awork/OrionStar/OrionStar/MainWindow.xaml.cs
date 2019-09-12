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

namespace OrionStar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ClickShow(object sender, RoutedEventArgs e) //make a event show informations when click
        {
            Label[] starts = { L1, L2, L3, L4, L5, L6, L7 }; //creat a group include all labels whcih named L1-L7
            foreach (var item in starts) //use foreach make all items in labels visible
            {
                item.Visibility = Visibility.Visible;
            }
        }
        private void ClickHide(object sender, RoutedEventArgs e) //make a event hide information when click
        {
            Label[] starts = { L1, L2, L3, L4, L5, L6, L7 }; //creat a group include all labels 
            foreach (var item in starts) //use foreach make all items in labels hide
            {
                item.Visibility = Visibility.Hidden;
            }
        }
    }
}
