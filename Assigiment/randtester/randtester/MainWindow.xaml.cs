using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace randtester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();

        Random r1 = new Random(1);
        Random r2 = new Random(6);
        int firstNum, secndNum = 0;
        int correctAnswer = 0;
        int yourAnswer = 0;
        int totalQuiz = 0;
        int correctQuiz = 0;
        float Mode = 0.5f;
        string text = "";
        bool WR = false;

        public MainWindow()
        {
            InitializeComponent();
            MakeQuiz();
        }

        public void MakeQuiz()
        {
            if (Mode > 0.5)
            {
                firstNum = r1.Next(100, 500);
                secndNum = r2.Next(100, 500);
            }
            else
            {
                firstNum = r1.Next(10, 50) * 10;
                secndNum = r2.Next(10, 50) * 10;
            }
            correctAnswer = firstNum + secndNum;
            Quiz.Content = firstNum.ToString() + "+" + secndNum.ToString() + "=?";
            totalQuiz++;
            Ans.Clear();           
        }
        public void checkAns(int answer, int correct)
        {
            if (answer == correct)
            {
                ShowWR.Content = "YOU GET CORRECT";
                correctQuiz++;
                WR = true;
            }
            else
            {
                ShowWR.Content = "YOU GET WRONG";
                WR = false;
            }
            Mode = (correctQuiz / totalQuiz);
        }

        private void Ans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key<=Key.D9 || e.Key == Key.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        string wrongRight(bool tf)
        {
            if (tf == true)
            {
                return "    you Correct";
            }
            else
            {
                return "    you Wrong And Correct answer is "+correctAnswer.ToString();
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {

            try
            {

              int.TryParse(Ans.Text,out yourAnswer);
                checkAns(yourAnswer,correctAnswer);
                text += firstNum.ToString() + "+" + secndNum.ToString() + "=" + yourAnswer.ToString() + wrongRight(WR) + "  You got" + correctQuiz.ToString() + "/" + totalQuiz.ToString()+"\n";
                File.WriteAllText("Result.txt", text);
                MakeQuiz();

             
               
            }
            catch
            {
                Ans.Text = "Please write your answer here";
            }


        }
    }
}
