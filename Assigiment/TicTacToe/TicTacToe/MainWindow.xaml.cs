/* Assignment 8
   Group 10:   Yuliia Sauk, Daniil Kurta, Fei Yun, Laxen Sapani */
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TicTacToe
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
            DataContext = vm;
        }

        private void Test_Process(object sender, RoutedEventArgs e)
        {
            vm.NewGame();
        }
    }
    public class TicTacToeConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value)
            {
                case 0:
                    return "0";
                case 1:
                    return "X";
            }
            return false;
        }

       // public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
       // {
       //     throw new NotImplementedException();
       // }
    }
}
