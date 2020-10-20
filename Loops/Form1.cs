using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void run_bttn_Click(object sender, EventArgs e)
        {

            /*
            int count = 0;
            while (count <= 100)
            {
                output_lbl.Text = "Count = " + count;
                Console.WriteLine(count);
                MessageBox.Show("Count = " + count);
                count++;
            }
            
            String target = "Paper or plastic ? ";
            for (int i = 0; i < target.Length; i++)
            {
                output_lbl.Text = "Count = " + i;
                Console.WriteLine(i);
                MessageBox.Show("Count = " + i);
            }

            for (int dayofweek = 0; dayofweek < 7; dayofweek++)
            {
                output_lbl.Text = "day " + dayofweek;
                for (int hour = 0; hour < 24; hour++)
                {
                    //MessageBox.Show("hour " + hour);
                    for (int min = 0; min < 60; min++)
                    {
                        //MessageBox.Show("minute " + min);
                        for (int sec = 0; sec < 60; sec++)
                        {
                            Console.WriteLine("day:" + dayofweek + " hour:"+ hour + " minute:" + min + " seconds:" + sec);
                        }
                    }
                }
            }
            */

            String text = "Paper or plastic ? ";
            foreach (int letter in text)
            {
                MessageBox.Show(letter.ToString());
            }
        }
    }
}
