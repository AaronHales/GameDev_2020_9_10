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
        public Form1()
        {
            InitializeComponent();
        }

        private void guess_bttn_Click(object sender, EventArgs e)
        {
            win_lose.Visible = false;
            Random random = new Random();
            int num = random.Next(1,11);
            int player_num = Decimal.ToInt32(enter_num.Value);
            bool win;

            int tries = 0;
            if (player_num == num)
            {
                high_low_lbl.Visible = true;
                high_low_lbl.Text = "You Guessed the number";
                win = true;
            }
            else if (player_num < num)
            {
                high_low_lbl.Visible = true;
                high_low_lbl.Text = "Guessed number too low";
                win = false;
            }
            else
            {
                high_low_lbl.Visible = true;
                high_low_lbl.Text = "Guessed number too high";
            }

            if ((tries == 2) && (win = false))
            {
                guess_bttn.Visible = false;
                enter_num.Visible = false;
                win_lose.Text = "You lose";
                high_low_lbl.Text = "the number was: " + num.ToString();
            }
            tries++;

        }
    }
}
