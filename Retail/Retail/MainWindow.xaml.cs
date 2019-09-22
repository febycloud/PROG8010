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

namespace Retail
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
        public static float Coupon(int num)
        {
            if (num < 10) { return 1.00f*num; }
            else if (num >= 10 && num < 20) { return 0.80f*num; }
            else if (num >= 20 && num < 50) { return 0.70f*num; }
            else if (num >= 50 && num < 100) { return 0.60f*num; }
            else { return 0.50f*num; }
        }

    private void Packs_TextChanged(object sender, TextChangedEventArgs e)
        {
            int price = 99;
           
            try
            {
                int number;
                int.TryParse(packs.Text, out number);
                if (number>0)
                {                  
                    pricenow.Text = (Coupon(number) * price).ToString();
                    pricewas.Text = (price * number).ToString();
                    discount.Text = (100 * (number - Coupon(number)) / number).ToString() + "%";
                }
            }
            catch { }
                    
        }
    }
}
