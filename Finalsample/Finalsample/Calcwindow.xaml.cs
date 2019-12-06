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

namespace Finalsample
{
    /// <summary>
    /// Interaction logic for Calcwindow.xaml
    /// </summary>
    /// Name my name
    public partial class Calcwindow : Window
    {
        public Calcwindow(VM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
