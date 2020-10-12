using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeepers__Beepers_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void for_bttn_Click(object sender, EventArgs e)
        {
            // Declare an int variable and set  it equal to the value in the 
            // NumBeepsText textbox. Use the  int.Parse() method to translate
            // the text to a number.
            int num_beeps = int.Parse(beeps_txt.Text);

            // validate user input to ensure the number is greater than zero
            if (num_beeps > 0)
            {
                // Create a for loop that will  start at 0 and continue while  
                // 'i' is less than the number of time  the user wants to beep.
                for (int i = 0; i < num_beeps; i++)
                {
                    // Make the computer beep!
                    Console.Beep();
                }
            }
            else
            {
                MessageBox.Show("Please enter a positive number");
            }
        }

        private void while_bttn_Click(object sender, EventArgs e)
        {
            // Create a variable to count the  number of times we have beeped
            int count = 0;

            // Declare an int variable and set  it equal to the value in the 
            // NumBeepsText textbox. Use the  int.Parse() method to translate
            // the text to a number.
            int num_beeps = int.Parse(beeps_txt.Text);

            // validate user input to ensure the number is greater than zero
            if (num_beeps > 0)
            {
                // Create  while loop that will  loop while  number of times we 
                // have beeped is less than  number  that  user wants us to beep
                while (count < num_beeps)
                {
                    // Make the computer beep!
                    Console.Beep();
                    // increment our beep counter -  VERY IMPORTANT!!
                    count++;
                }
            }
            else
            {
                MessageBox.Show("Please enter a positive number");
            }
        }

        private void do_bttn_Click(object sender, EventArgs e)
        {
            // Create a variable to count the  number of times we have beeped
            int count = 0;

            // Declare an int variable and set  it equal to the value in the 
            // NumBeepsText textbox. Use the  int.Parse() method to translate
            // the text to a number.
            int num_beeps = int.Parse(beeps_txt.Text);

            // validate user input to ensure the number is greater than zero
            if (num_beeps > 0)
            {
                // Create a do loop that will loop  while  the number of times 
                // we have beeped is less than the number  the user entered
                do
                {
                    // Make the computer beep!
                    Console.Beep();
                    // increment our beep counter -  VERY IMPORTANT!!
                    count++;
                }
                while (count < num_beeps);
            }
            else
            {
                MessageBox.Show("Please enter a positive number");
            }
        }
    }
}
