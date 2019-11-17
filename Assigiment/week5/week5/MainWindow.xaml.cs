using System;
using System.Collections.Generic;
using System.IO;
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

namespace week5
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
        }
        Random r = new Random(date);
        
 
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string text = string.Empty;
            File.AppendAllText("output.txt", "need to input string");
            int x = 0;
            while (x < 7)
            {

                int v = r.Next(1, 21);
                x++;
                text += v + ' ';
            }
            File.AppendAllText("output.txt", text);
            File.AppendAllText("output.txt", Environment.NewLine);
            File.AppendAllText("output.txt", text);
            for (int i = 0; i < 7; i++)
            {
                lb.Items.Add(i);
            }
            int z = 0;
            do
            {
                lb.Items.Add(r.Next());
                z++;
               
            } while (z<7);

            
        }
    }
}
