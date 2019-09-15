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

namespace StadiumSeating
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

        
        private void Compute_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int seatA = int.Parse(Aseat.Text); // get number from seaA label
                int seatB = int.Parse(Bseat.Text);
                int seatC = int.Parse(Cseat.Text);
                IncomeA.Content = (decimal)(seatA * 15); //Compute the income of A seat
                IncomeB.Content = (decimal)(seatB * 12);
                IncomeC.Content = (decimal)(seatC * 9);
                IncomeTotal.Content = (decimal)(seatA * 15 + seatB * 12 + seatC * 9); //compute income of total
            }
            catch
            {
                MessageBox.Show("Fill all the textbox");
            }
        }

        private void Seat_KeyDown(object sender, KeyEventArgs e)  // start check when press the key
        {
            if( e.Key>=Key.D0 && e.Key <= Key.D9 || e.Key == Key.Back) //when a key from 0-9 or back is pressed
            {
                e.Handled = false; //recive the value of key 
            }
            else
            {
                e.Handled = true; // dont recive the value of key
            }
        }
    }
}
