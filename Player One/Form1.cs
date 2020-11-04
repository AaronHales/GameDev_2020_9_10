using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player_One
{
    public partial class Form1 : Form
    {
        public int WIDTH = 250;
        public int HEIGHT = 250;
        public Label lbl_name = new Label();
        public TextBox txt_box = new TextBox();
        public Button bttn = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // setup label
            this.Size = new Size(WIDTH, HEIGHT);
            this.lbl_name.Location = new Point(WIDTH / 2 - 50, HEIGHT / 2 - 65);
            this.lbl_name.Size = new Size(100, 15);
            this.lbl_name.Text = "Enter player name:";

            // setup text box
            this.txt_box.Size = new Size(120, 50);
            this.txt_box.Location = new Point(WIDTH / 2 - 60, HEIGHT / 2 - 40);

            // setup button
            this.bttn.Size = new Size(120, 35);
            this.bttn.Location = new Point(WIDTH / 2 - 60, HEIGHT / 2);
            this.bttn.Text = "Start";
            this.bttn.Click += new EventHandler(button1_Click);



            // adds them to the form
            this.Controls.Add(lbl_name);
            this.Controls.Add(txt_box);
            this.Controls.Add(bttn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player Name is: " + txt_box.Text);
            txt_box.Text = "";
        }
    }
}
