using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //Score Matrix
        int[,] marks = new int[3,3];

        //Keep track of whos turn it is
        bool oTurn = true;

        //Count how many buttons that has been used
        int count;

        //Score for players
        int scoreX = 0;
        int scoreO = 0;



        public Form1()
        {
            InitializeComponent();

            //Set Score label on init
            s_O.Text = "" + scoreO;
            s_X.Text = "" + scoreX;
        }


        //Method to handle button clicks
        private void button_Click(object sender, EventArgs e)
        {
            //Get reference to the button that was clicked
            Button b = (Button)sender;

            //Return (cancel) if button is occupied/used
            if(b.Text != "")
            {
                return;
            }

            //Add x/o's points to the scorematrix based on whos turn it is
            if (oTurn)
            {
                b.Text = "O";
                int i = int.Parse(b.Name.Substring(1));

                int col = i % 3;
                int row = i / 3;

                marks[col, row] = 1;

            }
            else
            {
                b.Text = "X";

                int i = int.Parse(b.Name.Substring(1));

                int col = i % 3;
                int row = i / 3;

                marks[col, row] = -1;

            }

            //Change whose turn it is
            oTurn = !oTurn;

            //Add one to the count to check for tie later
            count++;

            //Check if the current round is over (winner? tie?)
            if (IsOver())
            {
                s_O.Text = "" + scoreO;
                s_X.Text = "" + scoreX;
                Reset();
            }

        }

        private bool IsOver()
        {
            //Game is tied if no free buttons are left
            if (count > 8)
            {
                MessageBox.Show("You tied the game!");
                return true;
            }

            //Check cols/rows for winner
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                //Check all the Columns for a winner
                if (marks[i, 0] + marks[i, 1] + marks[i, 2] == -3)
                {
                    scoreX++;
                    MessageBox.Show("X Won the game!");
                    return true;
                }
                else if (marks[i, 0] + marks[i, 1] + marks[i, 2] == 3)
                {
                    scoreO++;
                    MessageBox.Show("O Won the game!");
                    return true;
                }

                //Check all the rows for a winner
                if (marks[0, i] + marks[1, i] + marks[2, i] == -3)
                {
                    scoreX++;
                    MessageBox.Show("X Won the game!");
                    return true;
                }
                else if (marks[0, i] + marks[1, i] + marks[2, i] == 3)
                {
                    scoreO++;
                    MessageBox.Show("O Won the game!");
                    return true;
                }


            }

            //Check the diagonal for X
            if(marks[0,0] + marks[1,1] + marks[2,2] == -3 || marks[0,2] + marks[1,1] +  marks[2,0] == -3)
            {
                scoreX++;
                MessageBox.Show("X Won the game!");
                return true;
            }

            //Check the diagonal for O
            if (marks[0, 0] + marks[1, 1] + marks[2, 2] == 3 || marks[0, 2] + marks[1, 1] + marks[2, 0] == 3)
            {
                scoreO++;
                MessageBox.Show("O Won the game!");
                return true;
            }


            return false;

        }

        //Reset the round
        private void Reset()
        {
            //Zero scorematrix
            marks = new int[3, 3];

            //Restart count
            count = 0;

            //Set the text of all button to empty
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Text = "";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
