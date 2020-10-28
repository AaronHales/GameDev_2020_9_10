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
        public ListBox list_box1 = new ListBox();



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
            this.txt_box.Multiline = true;
            this.txt_box.ScrollBars = ScrollBars.Vertical;

            // label setup section
            this.label_name.Size = new System.Drawing.Size(500, 13);
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_name.Visible = true;
            this.label_name.Location = new System.Drawing.Point(0, (HEIGHT / 4) - 50);
            this.label_name.Text = "Starting text";

            // bttn setup
            this.bttn_one.Text = "Button";
            this.bttn_one.Location = new System.Drawing.Point((WIDTH / 2) - 50, HEIGHT - 100);
            this.bttn_one.Size = new System.Drawing.Size(100, 50);
            this.bttn_one.BackColor = Color.WhiteSmoke;
            this.bttn_one.Click += new EventHandler(button_Click);

            // list box setup
            double x = HEIGHT * .75;
            this.list_box1.Location = new System.Drawing.Point((WIDTH / 2) - 100, (int)x - 150);
            this.list_box1.Size = new System.Drawing.Size(200,150);
            this.list_box1.SelectionMode = SelectionMode.MultiExtended;

            // adding items
            list_box1.Items.Add("testing");
            list_box1.Items.Add("testing 2");
            list_box1.Items.Clear();
            // array
            String[] toppings = { "Pepperoni", "Pineapple", "Black Olives", "Green Olives", "Sausage", "Ham", "Beef", "Bacon",
            "Peppers","Onions", "Mushrooms", "Tomatoes", "Spinach", "Cheese", "Chicken", "Jalapeno", "Ranch Dressing", "Buffalo Sauce",
            "Anchovies","Roasted Beets", "Roasted Potatoes", "Pesto Sauce", "Caramelized Onions", "Goat Cheese", "Grilled Prawns" };

            // adds items to the length of array
            for (int i = 0; i < toppings.Length; i++)
            {
                list_box1.Items.Add(toppings[i]);
            }
            



            // adds to form section
            this.Controls.Add(txt_box);
            this.Controls.Add(label_name);
            this.Controls.Add(bttn_one);
            this.Controls.Add(list_box1);

        }

        private void button_Click(object sender, EventArgs e)
        {
            int num_selected = list_box1.SelectedItems.Count;
            if (num_selected > 0)
            {
                for (int i = 0; i < num_selected; i++)
                {
                    int index = list_box1.SelectedIndices[i];

                    string lastSelection = (string)list_box1.Items[index];
                    MessageBox.Show(lastSelection);
                }
            }
           
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
