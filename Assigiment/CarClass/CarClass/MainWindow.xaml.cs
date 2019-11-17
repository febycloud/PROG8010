using System.Windows;

namespace CarClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Assignment 9
    ///Group 10:   Yuliia Sauk, Daniil Kurta, Fei Yun, Laxen Sapani*/
    public partial class MainWindow : Window
    {
              public VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            vm.VMadd();
        }

        private void SpeedUp_Click(object sender, RoutedEventArgs e)
        {
            if (vm.SelectCar != null)
            {
                vm.AddSpeed(vm.SelectCar);
                Items.Items.Refresh();
            }
        }

        private void SpeedDown_Click(object sender, RoutedEventArgs e)
        {
            if (vm.SelectCar != null)
            {
                vm.SlowDown(vm.SelectCar);
                Items.Items.Refresh();
            }
        }
    }
}

