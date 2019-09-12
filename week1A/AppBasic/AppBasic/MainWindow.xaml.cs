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

namespace AppBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() /* Build window class*/
        {
            InitializeComponent(); /*run XAML*/
        }

        private void DoIt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello message","Title here",MessageBoxButton.OK,MessageBoxImage.Exclamation); /*Show a message in messagebox*/
            Image1.Visibility = Visibility.Hidden; //change image1 visibility to hidden
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            OutputText.Content = "goodbye"; /*Click image to change from hello to goodbye on lable*/
            Image1.Visibility = Visibility.Visible; //change image1 visibility to visiable

        }
    }
}
