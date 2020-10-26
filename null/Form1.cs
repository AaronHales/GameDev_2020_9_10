using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace @null
{
    public partial class Form1 : Form
    {
        int HEIGHT = 500;
        int WIDTH = 500;
        public TextBox txt_box = new TextBox();
        public Label label_name = new Label();
        public Button bttn_one = new Button();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // form setup section
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.CornflowerBlue;
            this.ForeColor = Color.Black;
            this.Size = new System.Drawing.Size(WIDTH, HEIGHT);
            this.Text = "Form Setup";
            this.StartPosition = FormStartPosition.CenterScreen;

            // textbox setup section
            this.txt_box.Text = "Enter your name";
            this.txt_box.Location = new System.Drawing.Point((WIDTH / 2) - 50, (HEIGHT / 4) - 25);
            this.txt_box.Size = new System.Drawing.Size(100, 100);
            this.txt_box.Visible = true;
            this.txt_box.Enabled = true;
            this.txt_box.TextChanged += new EventHandler(textBox1_TextChanged);
            this.txt_box.MouseHover += new EventHandler(textBox1_TextChanged_1);
            //this.txt_box.Multiline = true;
            //this.txt_box.ScrollBars = ScrollBars.Vertical;

            // label setup section
            this.label_name.Visible = true;
            this.label_name.Location = new System.Drawing.Point((WIDTH / 2) - 50, (HEIGHT / 4) - 50);
            this.label_name.Text = "Starting text";

            // button setup
            this.bttn_one.Text = "Button";
            this.bttn_one.Location = new System.Drawing.Point(0, 0);
            this.bttn_one.Size = new System.Drawing.Size(50, 50);
            this.bttn_one.BackColor = Color.WhiteSmoke;


            // adds to form section
            this.Controls.Add(txt_box);
            this.Controls.Add(label_name);
            this.Controls.Add(bttn_one);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label_name.Text = this.txt_box.Text;
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            label_name.Text = "remove mouse from text box";
            Console.Beep();
            Console.Beep();
            MessageBox.Show("No mouse on text box!");
        }
    }
}
