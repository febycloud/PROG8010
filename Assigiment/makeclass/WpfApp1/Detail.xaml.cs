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
    /// Interaction logic for Detail.xaml
    /// </summary>
    public partial class Detail : Window
    {
        Product p;
        public Detail(Product p)
        {
            InitializeComponent();
            this.p = p;
            //ID.Content = p.ID;
            //Des.Content = p.Description;
            //Pri.Content = p.Price;
            //Tostr.Content = p.ToString();
        }
        public Detail(VM vm)
        {
           InitializeComponent();
            DataContext = vm;
        }
    }
}
