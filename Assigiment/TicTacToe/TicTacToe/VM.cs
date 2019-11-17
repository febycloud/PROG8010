using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TicTacToe
{
    internal class VM : INotifyPropertyChanged
    {
        private const int width = 3;
        private const int height = 3;
        public int[][] Matrix
        {
            get => matrix;
            set { matrix = value; notifyChange(); }
        }
        private int[][] matrix = new int[width][];

        public String Info
        {
            get => info;
            set { info = value; notifyChange(); }
        }
        private string info;

        public void NewGame()
        {
            Info = "";
            Random random = new Random();
            for (int i = 0; i < Matrix.Length; i++)
            {
                int[] buf = new int[height];
                for (int j = 0; j < buf.Length; j++)
                {
                    buf[j] = random.Next(0, 2);
                }
                Matrix[i] = buf;
            }
            notifyChange("Matrix");
            Info = "it is a draw!";
            checkAllDiagonals();
            checkAllRows();
            checkAllColumns();
        }

        private void checkAllRows()
        {
            int countforP1 = 0;
            int countforP2 = 0;

            for (int i = 0; i < 3; i++)
            {
                countforP1 = 0;
                countforP2 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (Matrix[i][j] == 0)
                    {
                        countforP1++;
                    }
                    if (Matrix[i][j] == 1)
                    {
                        countforP2++;
                    }

                    if (countforP1 == 3)
                    {
                        Info = "Player O won";
                        break;
                    }
                    if (countforP2 == 3)
                    {
                        Info = "Player X won";
                        break;
                    }
                }
            }
        }

        private void checkAllColumns()
        {
            int countforP1 = 0;
            int countforP2 = 0;

            for (int i = 0; i < 3; i++)
            {
                countforP1 = 0;
                countforP2 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (Matrix[j][i] == 0)
                    {
                        countforP1++;
                    }
                    if (Matrix[j][i] == 1)
                    {
                        countforP2++;
                    }

                    if (countforP1 == 3)
                    {
                        Info = "Player O won";
                        break;
                    }
                    if (countforP2 == 3)
                    {
                        Info = "Player X won";
                        break;
                    }
                }
            }
        }

        private void checkAllDiagonals()
        {
            int counterLeftP1 = 0;
            int counterRightP1 = 0;
            int counterLeftP2 = 0;
            int counterRightP2 = 0;


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j && Matrix[i][j] == 0)
                    {
                        counterLeftP1++;
                    }

                    if (i + j == height -1 && Matrix[i][j] == 0)
                    {
                        counterRightP1++;
                    }

                    if (i == j && Matrix[i][j] == 1)
                    {
                        counterLeftP2++;
                    }

                    if (i + j == height - 1 && Matrix[i][j] == 1)
                    {
                        counterRightP2++;
                    }

                    if (counterLeftP1 == 3 || counterRightP1 == 3)
                    {
                        Info = "Player O won";
                        break;
                    }
                    if (counterLeftP2 == 3 || counterRightP2 == 3)
                    {
                        Info = "Player X won";
                        break;
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void notifyChange([CallerMemberName]string property = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

    }
}
