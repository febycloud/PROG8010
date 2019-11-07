using System;
using System.Windows;

namespace isprime
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
            this.DataContext = vm;
        }

        public bool isPrime(int num)
        {
            if (num == 2 || num == 3)
            {
                return true;
            }
            if (num % 6 != 1 && num % 6 != 5)
            {
                return false;
            }
            int tmp = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(num)));
            for (int i = 5; i <= tmp; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int size = vm.TargetNum;

            for (int i = 2; i <= size; i++)
            {
                if (isPrime(i) == true)
                {
                    primeResult.Items.Add(i);
                }
            }
        }
    }
}
