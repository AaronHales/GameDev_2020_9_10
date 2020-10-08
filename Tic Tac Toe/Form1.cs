/*
 * Game Development
 * 
 * Aaron Hales
 * Tic Tak Toe
 * 10/8/20
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{

    public partial class Form1 : Form
    {
        // Class level Variables
        public int player = 2; // even = x turn odd = o turn
        public int turns = 0; // counting turns
        public int score1 = 0; // x wins
        public int score2 = 0; // o wins
        public int score3 = 0; // draws

        public Form1()
        {
            InitializeComponent();
        }

        void NewGame()
        {
            player = 2;
            turns = 0;
            x_wins_lbl.Text = "X: " + score1;
            o_wins_lbl.Text = "O: " + score2;
            draw_lbl.Text = "Draw: " + score3;
            bttn_0_0.Text = bttn_0_1.Text = bttn_0_2.Text = bttn_1_0.Text = bttn_1_1.Text = bttn_1_2.Text = bttn_2_0.Text = bttn_2_1.Text = bttn_2_2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            NewGame();
        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            // only lets click if text is empty
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++; // adds one to player to make odd player
                    turns++;

                }
                else
                {
                    button.Text = "O";
                    player++; // adds one to player to make even turn
                    turns++;

                }
            }
            else
            {
                Console.WriteLine("NO CHEATING\nI THOUGHT YOU WERE BETTER THAN THIS");
            }
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_game_bttn_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void reset_bttn_Click(object sender, EventArgs e)
        {
            score1 = 0; // x wins
            score2 = 0; // o wins
            score3 = 0; // draws
            NewGame();
        }
    }
}
