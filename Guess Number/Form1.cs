using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Number
{
    public partial class Form1 : Form
    {
        public int tries;
        public int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            num = random.Next(1, 11);
            tries = 3;
            win_lost_lbl.Visible = false;
        }

        private void guess_bttn_Click(object sender, EventArgs e)
        {
            int player_num = Decimal.ToInt32(enter_num.Value);

            if (tries > 1)
            {
                if (player_num == num)
                {
                    MessageBox.Show("You guessed the number");
                    win_lost_lbl.Text = "YOU WIN";
                }
                else if (player_num < num)
                {
                    tries--;
                    MessageBox.Show("You guess to low\nTries left: " + tries);
                }
                else
                {
                    tries--;
                    MessageBox.Show("You guessed to high\nTries left: " + tries);
                }

            }
            else
            {
                guess_bttn.Visible = false;
                enter_num.Visible = false;
                win_lost_lbl.Visible = true;
                win_lost_lbl.ForeColor = Color.Red;
                win_lost_lbl.Text = "YOU LOST";
                MessageBox.Show("You lost\nThe number was " + num);
            }

        }


    }
}
