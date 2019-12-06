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
namespace tictactoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      public Dictionary<string, Label> Pairs = new Dictionary<string, Label>();
        public MainWindow()
        {
            InitializeComponent();
            Pairs.Add("00", L00);
            Pairs.Add("01", L01);
            Pairs.Add("02", L02);
            Pairs.Add("10", L10);
            Pairs.Add("11", L11);
            Pairs.Add("12", L12);
            Pairs.Add("20", L20);
            Pairs.Add("21", L21);
            Pairs.Add("22", L22);
        }

        private void Pvestart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[,] Location = new int[3, 3] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
                System.Random random = new Random();
                int place11 = random.Next(0, 2);
                int place12 = random.Next(0, 2);
                int place01 = random.Next(0, 2);
                int place02 = random.Next(0, 2);
                bool exit = false;
                Location[place11, place12] = 1;
                //set labelname
                string labelName = place11.ToString() + place12.ToString();
                //set dictionaty

                //binding location and name

                //set first is 1
                Pairs[labelName].Content = "X";

                int full = 9;

                while (full > 1)
                {
                Resetplayer1:
                    place11 = random.Next(0, 3);
                    place12 = random.Next(0, 3);
                    if (Location[place11, place12] == 2)
                    {
                        Location[place11, place12] = 1;
                        labelName = place11.ToString() + place12.ToString();
                        Pairs[labelName].Content = "X";
                        full--;
                    }
                    else
                    {
                        goto Resetplayer1;
                    }

                Resetplayer2:
                    place01 = random.Next(0, 3);
                    place02 = random.Next(0, 3);
                    if (place11 == place01 && place12 == place02)
                    {
                        goto Resetplayer2;
                    }
                    if (Location[place01, place02] == 2)
                    {
                        Location[place01, place02] = 0;
                        labelName = place01.ToString() + place02.ToString();
                        Pairs[labelName].Content = "O";
                        full--;
                        
                    }
                    else
                    {
                        goto Resetplayer2;
                    }
                    
                }
                checkWin();



                void checkWin()
                {
                    for(int i = 0; i < 3; i++)
                    {
                        if (Location[i, 0] == Location[i, 1] && Location[i, 1] == Location[i, 2] && Location[i, 1] != 2&&Location[i,0]!=2&&Location[i,2]!=2)
                            MessageBox.Show(Location[i, 1] + " is won");
                        break;
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        if (Location[0, i] == Location[1, i] && Location[2, i] == Location[0, i] && Location[0, i] != 2&&Location[1,i]!=2&&Location[2,i]!=2)
                            MessageBox.Show(Location[0, i] + " is won");
                        break;
                    }
                    if(Location[0, 0] == Location[1, 1] && Location[1, 1] == Location[2, 2] && Location[1, 1] != 2&&Location[0,0]!=2&&Location[2,2]!=2)
                        MessageBox.Show(Location[1, 1] + " is won");
                    if(Location[0, 2] == Location[1, 1] && Location[1, 1] == Location[2, 0] && Location[1, 1] != 2&&Location[2,0]!=2&&Location[0,2]!=2)
                        MessageBox.Show(Location[1, 1] + " is won");

                    
                   

                }


            }
            catch
            {

            }

            }


            }
           

        }

        
    

