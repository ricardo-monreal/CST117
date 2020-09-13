using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject4
{
    public partial class Form1 : Form
    {
        // 2d int array
        int[,] arr;
        // 2d string array
        string[,] board;

        // track X count
        int xCount;
        // track O count
        int oCount;

        public Form1()
        {
            InitializeComponent();

            // call method to start game
            StartBoard();
        }




        // method to initialize game, setup board and counter
        private void StartBoard()
        {
            arr = new int[3, 3];
            board = new string[3, 3];
            xCount = 0;
            oCount = 0;
        }

        //private void ProgrammingProject4_Load(object sender,EventArgs e)
        //{

        //}


        // method to fill array arr with random numbers and store O or X to the array board
        private void FillArray()
        {
            // create a random object
            Random rand = new Random();



            //      Board Design
            //
            //       col0   col1   col2
            //
            //row 0  [0,0], [0,1], [0,2]
            //row 1  [1,0], [1,1], [1,2]
            //row 2  [2,0], [2,1], [2,2]
            //

            // store random generated numbers in array index
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    arr[row, col] = rand.Next(0, 2);


                    // O = 0, X = 1
                    if (arr[row, col] == 0)
                    {
                        board[row, col] = "O";
                        oCount++;
                    }
                    else
                    {
                        board[row, col] = "X";
                        xCount++;
                    }
                }
            }
        }

        // method to set random array values to labels
        private void SetGameTable()
        {
            //display index of boards array in the lables




            lbl_1.Text = board[0, 0];
            lbl_2.Text = board[0, 1];
            lbl_3.Text = board[0, 2];
            lbl_4.Text = board[1, 0];
            lbl_5.Text = board[1, 1];
            lbl_6.Text = board[1, 2];
            lbl_7.Text = board[2, 0];
            lbl_8.Text = board[2, 1];
            lbl_9.Text = board[2, 2];

        }

        // method to check for winner

        private void CheckForWinner()
        {
            if (WinByRow("X")) 
            {
                lbl_Result.Text = "X Wins!";
                return;
            }
            else if (WinByRow("O"))
            {
                lbl_Result.Text = "O Wins!";
                return;
            }
            else if (WinByColumn("X"))
            {
                lbl_Result.Text = "X Wins!";
                return;
            }
            else if (WinByColumn("O"))
            {
                lbl_Result.Text = "O Wins!";
                return;
            }
            else if (WinByDiagonal("X"))
            {
                lbl_Result.Text = "X Wins!";
                return;
            }
            else if (WinByDiagonal("O"))
            {
                lbl_Result.Text = "O Wins!";
                return;
            }
            else
            {
                lbl_Result.Text = "Its a tie!";
            }
        }

        // method to check for row winner
        private Boolean WinByRow(string charValue)
        {
            for (int row = 0; row < 3; row++)
            {
                if ((board[row,0] == board[row,1]) && (board[row,0] == board[row,2]))
                {
                    if (board[row, 0].Equals(charValue))
                        return true;
                }
            }
            return false;
        }

        // method to check for column winner
        private Boolean WinByColumn(string charValue)
        {
            for (int col = 0; col < 3; col++)
            {
                if ((board[0, col] == board[1, col]) && (board[1, col] == board[2,col]))
                {
                    if (board[col, 0].Equals(charValue))
                        return true;
                }
            }
            return false;
        }

        // method to check for diagonal winner
        private Boolean WinByDiagonal(string charValue)
        {
            // check from left to to right diagonally
           
            if ((board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]))
            {
                if (board[0, 0].Equals(charValue))
                    return true;
            }
            // check from right to left diagonally
            if ((board[0, 2] == board[1,1]) && (board[1,1] == board[2,0]))
            {
                if (board[1, 1].Equals(charValue))
                    return true;
            }
            return false;
        }

      

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            // loop to fill array and keep max count of X or O
            do
            {
                StartBoard();
                FillArray();
                if ((oCount == 4 && xCount == 5) || (oCount == 5 && xCount == 4))
                {
                    break;
                }
            } while (true);
            // call method to display board
            SetGameTable();
            // call method that checks for winner
            CheckForWinner();
        }
        // close app
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
