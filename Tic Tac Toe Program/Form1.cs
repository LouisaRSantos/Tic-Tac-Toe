using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Program
{
    public partial class TicTacToe : Form
    {
        bool PlayerTurn = true;
        int PlayerTurn_count = 0;
        

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void MenuCreatorAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Player!\r\n" + "\r\n" + "The program was created by a BSCOE Student\r\n" + "at PUP named Louisa Reighn A. Santos.", "About the Creator");
        }

        private void MenuCreatorGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Tic-Tac-Toe is a game in which two players seek\r\n" + "in alternate turns to complete a row, a column, or \r\n" + "a diagonal with either three O's or three X's drawn \r\n" + "in the spaces of a grid of nine squares.", "About the Game");
        }

        private void MenuHelpProcedure_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Steps in playing Tic-Tac-Toe:\r\n" + "1. Have the first player go first.\r\n" + "2. Have the second player go next.\r\n" + "3. Keep alternating moves until one has drawn a row of three X or O.\r\n" + "4. Enjoy the game!", "How to play Tic-Tac-Toe");
        }

        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnclick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (PlayerTurn)
            {
                btn.Text = "X";
                btn.BackColor = Color.PaleGoldenrod;
            }
            else
            {
                btn.Text = "O";
                btn.BackColor = Color.LightGoldenrodYellow;
            }

            PlayerTurn = !PlayerTurn;   //to create the alternating turn
            btn.Enabled = false;        //to disable the button after clicking once
            PlayerTurn_count++;

            checking_of_winner();
        }

        private void checking_of_winner()
        {
            bool TheWinner = false;

            //Horizontal
            if ((TicTacbtn1.Text == TicTacbtn2.Text) && (TicTacbtn2.Text == TicTacbtn3.Text) && (!TicTacbtn1.Enabled))
                TheWinner = true;
            else if ((TicTacbtn4.Text == TicTacbtn5.Text) && (TicTacbtn5.Text == TicTacbtn6.Text) && (!TicTacbtn4.Enabled))
                TheWinner = true;
            else if ((TicTacbtn7.Text == TicTacbtn8.Text) && (TicTacbtn8.Text == TicTacbtn9.Text) && (!TicTacbtn7.Enabled))
                TheWinner = true;

            //Vertical
            else if ((TicTacbtn1.Text == TicTacbtn4.Text) && (TicTacbtn4.Text == TicTacbtn7.Text) && (!TicTacbtn1.Enabled))
                TheWinner = true;
            else if ((TicTacbtn2.Text == TicTacbtn5.Text) && (TicTacbtn5.Text == TicTacbtn8.Text) && (!TicTacbtn2.Enabled))
                TheWinner = true;
            else if ((TicTacbtn3.Text == TicTacbtn6.Text) && (TicTacbtn6.Text == TicTacbtn9.Text) && (!TicTacbtn3.Enabled))
                TheWinner = true;

            //Diagonal
            else if ((TicTacbtn1.Text == TicTacbtn5.Text) && (TicTacbtn5.Text == TicTacbtn9.Text) && (!TicTacbtn1.Enabled))
                TheWinner = true;
            else if ((TicTacbtn3.Text == TicTacbtn5.Text) && (TicTacbtn5.Text == TicTacbtn7.Text) && (!TicTacbtn5.Enabled))
                TheWinner = true;


            if (TheWinner)
            {
                disable_Buttons();

                string champion = "";
                if (PlayerTurn)
                    champion = "O";
                else 
                    champion = "X";
                
                MessageBox.Show("The Winner is" + " " + champion + "!\n" + "Select New Game to play again.", "TicTacToe Winner!");
            }
            else
            {
                if (PlayerTurn_count == 9)
                    MessageBox.Show("Draw!" + " " + "Please restart the game.", "Yikes!");
            }

        }

        private void disable_Buttons()
        {
            try
            {
                foreach (Control dis in Controls)
                {
                    Button btn = (Button)dis;
                    btn.Enabled = false;
                }
            }
            catch { }
        }

        private void MenuFileNewG_Click(object sender, EventArgs e)
        {
            PlayerTurn = true;
            PlayerTurn_count = 0;
            try
            {
                foreach (Control dis in Controls)
                {
                    Button btn = (Button)dis;
                    btn.Enabled = true;
                    btn.Text = "";
                    btn.BackColor = System.Drawing.Color.White;
                    btnreset.Text = "RESET";
                }
            }
            catch { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PlayerTurn = true;
            PlayerTurn_count = 0;
            try
            {
                foreach (Control dis in Controls)
                {
                    Button btn = (Button)dis;
                    btn.Enabled = true;
                    btn.Text = "";
                    btn.BackColor = System.Drawing.Color.White;
                    btnreset.Text = "RESET";
                }
                
            }
            catch { }
        }
  
    }
}

