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

namespace Week2
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

        private void DoIt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float s = float.Parse(FirstInput.Text);
                float b = float.Parse(SecondInput.Text);
                //string s = FirstInput.Text;
                //string b = SecondInput.Text;
                float m = s / b;
                decimal money = (decimal)m;
                OutputText.Content =money;
            }
            catch { MessageBox.Show("NO"); }
        }
    }
}
