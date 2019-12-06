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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 
    public delegate void myDel(string str);
    public partial class Window1 : Window
    {
        myDel mydel;
        public Window1(string txt,myDel md)
        {
            InitializeComponent();
            form2.Text = txt;
            this.mydel = md;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.mydel(form2.Text);
        }
    }
}
