using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flowcontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void roll_bttn_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // creates a random number between 1 and 6
            int player_die1 = random.Next(1,7); // bottom number is included while to number is not
            int player_die2 = random.Next(1, 7); // bottom number is included while to number is not

            int comp_die1 = random.Next(1, 7); // bottom number is included while to number is not
            int comp_die2 = random.Next(1, 7); // bottom number is included while to number is not

            // adds the numbers together
            int player_total = player_die1 + player_die2;
            int comp_total = comp_die1 + comp_die2;
            // changes the totals to strings 
            player_score_lbl.Text = player_total.ToString();
            comp_score_lbl.Text = comp_total.ToString();

            /*
             * comparison operators
             * >  greater than
             * <  less than
             * <= less than or equal to
             * >= greater than or equal to
             * == comparison operator
             * != not equal to
             * 
             * =  assignment operator
             * 
             * logical operation
             * and or exclusive not
             * 
             * and && 
             * or ||
             * 
             * exclusive ^
             * 
             * not !
             */




            if (player_total > comp_total) // if player total is greater than comp total exe code
            {
                winner_lbl.Visible = true;
                winner_lbl.Text = "Player!";
            }

            else if (player_total == comp_total) // if above 
            {
                winner_lbl.Visible = true;
                winner_lbl.Text = "Tie!";
            }

            else
            {
                winner_lbl.Visible = true;
                winner_lbl.Text = "Computer!";
            }

            Task.Delay(1000).Wait();
            winner_lbl.Visible = false;

            /*
            int x = 0;
            while (x < 10000)
            {
                x++;
                Console.WriteLine(x);
            }
            if (x >= 10000)
            {
                winner_lbl.Visible = false;
            }
            */


        }
    }
}
