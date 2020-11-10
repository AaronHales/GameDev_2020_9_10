using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Favorite_Food
{
    public partial class Form1 : Form
    {
        public GroupBox food_gb = new GroupBox();
        public RadioButton chinese = new RadioButton();
        public RadioButton mexican = new RadioButton();
        public RadioButton indian = new RadioButton();
        public Button choose_bttn = new Button();
        public int WIDTH = 400;
        public int HEIGHT = 400;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(WIDTH, HEIGHT);
            // setup group box
            this.food_gb.Size = new Size(200, 200);
            this.food_gb.Location = new Point(WIDTH / 2 - 100, HEIGHT / 2 - 170);
            this.food_gb.Text = "My favorite foods is...";

            this.food_gb.Controls.Add(chinese);
            this.chinese.Size = new Size(100, 50);
            this.chinese.Location = new Point(200 / 2 - 50, 20);
            this.chinese.Text = "Chinese";

            this.food_gb.Controls.Add(mexican);
            this.mexican.Size = new Size(100, 50);
            this.mexican.Location = new Point(200 / 2 - 50, 80);
            this.mexican.Text = "Mexican";

            this.food_gb.Controls.Add(indian);
            this.indian.Size = new Size(100, 50);
            this.indian.Location = new Point(200 / 2 - 50, 140);
            this.indian.Text = "Indian";

            // setup button
            this.choose_bttn.Size = new Size(100, 25);
            this.choose_bttn.Location = new Point(WIDTH / 2 - 50, HEIGHT - 150);
            this.choose_bttn.Text = "Choose";
            this.choose_bttn.Click += new EventHandler(button1_Click);



            // adds items to form
            this.Controls.Add(food_gb);
            this.Controls.Add(choose_bttn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chinese.Checked)
            {
                MessageBox.Show("General Tso's Chicken is tasty!");
                chinese.Checked = false;
            }
            else if (mexican.Checked)
            {
                MessageBox.Show("I love burritos!");
                mexican.Checked = false;
            }
            else if (indian.Checked)
            {
                MessageBox.Show("Try Chicken Tikka Masala!");
                indian.Checked = false;
            }
            else
            {
                MessageBox.Show("Make a selection!");
            }
        }
    }
}
