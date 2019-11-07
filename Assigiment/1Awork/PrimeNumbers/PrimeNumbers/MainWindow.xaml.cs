/* Assignment 5
   Group 10:   Yuliia Sauk, Daniil Kurta, Fei Yun, Laxen Sapani */
using System;
using System.Windows;

namespace PrimeNumbers
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HideNumbers(this, new RoutedEventArgs());
        }

        private void ShowNumbers(object sender, RoutedEventArgs e)
        {
            for (uint i = 0; i < 100; i++)
            {
                if (IsPrime(i))
                {
                    NumbersList.Items.Add(i);
                }
            }
        }

        private void HideNumbers(object sender, RoutedEventArgs e)
        {
            NumbersList.Items.Clear();
            TheNumber.Text = null;
            TheResult.Content = null;
        }

        private void CheckPrime(object sender, RoutedEventArgs e)
        {
            try
            {
                uint number = uint.Parse(TheNumber.Text);
                if(IsPrime(number))
                {
                    TheResult.Content = number + " is prime.";
                } else
                {
                    TheResult.Content = number + " is not prime.";
                }
            }
            catch
            {
                TheResult.Content = "Invalid input.";
            }
        }

        public static bool IsPrime(uint number)
        {
            if (number == 2)
                return true;
            if (number == 1 || number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}
