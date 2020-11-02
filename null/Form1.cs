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
        public ComboBox c_box1 = new ComboBox();
        public CheckBox cb1 = new CheckBox();
        public CheckBox cb2 = new CheckBox();
        public CheckBox cb3 = new CheckBox();
        public GroupBox group_box = new GroupBox();
        public RadioButton rb1 = new RadioButton();
        public RadioButton rb2 = new RadioButton();
        public RadioButton rb3 = new RadioButton();


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
            this.label_name.Size = new System.Drawing.Size(100, 13);
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_name.Visible = true;
            this.label_name.Location = new System.Drawing.Point(WIDTH / 2 - 50, (HEIGHT / 4) - 50);
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
            this.list_box1.Size = new System.Drawing.Size(200, 150);
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

            // combo box setup
            this.c_box1.Location = new System.Drawing.Point(WIDTH / 2 - 100, 40);
            this.c_box1.Size = new System.Drawing.Size(200, 50);
            this.c_box1.DropDownStyle = ComboBoxStyle.DropDownList;

            // adding items for combo box
            c_box1.Items.Add("Testing 1");
            c_box1.Items.Add("Testing 2");
            c_box1.Items.Clear();
            String[] crust_types = { "Thin Crust", "Stuffed Crust", "Pan Crust", "Prezel Crust", "Deep Dish Crust", "Regular Crust" };
            for (int i = 0; i < crust_types.Length; i++)
            {
                c_box1.Items.Add(crust_types[i]);
            }
            c_box1.SelectedIndex = 1;


            // checkbox setup
            this.cb1.Location = new System.Drawing.Point(WIDTH / 4 - 100, 40);
            this.cb2.Location = new System.Drawing.Point(WIDTH / 4 - 100, 65);
            this.cb3.Location = new System.Drawing.Point(WIDTH / 4 - 100, 90);
            this.cb1.Text = "Salad";
            this.cb2.Text = "Bread Sticks";
            this.cb3.Text = "Hot Wings";
            cb2.Checked = true;

            // group box setup
            this.group_box.Location = new System.Drawing.Point(WIDTH / 4 - 100, 125);
            this.group_box.Size = new System.Drawing.Size(100, 100);
            this.group_box.Text = "Tip";
            this.rb1.Text = "10%";
            this.rb2.Text = "15%";
            this.rb3.Text = "20%";
            this.rb1.Location = new System.Drawing.Point(10, 20);
            this.rb2.Location = new System.Drawing.Point(10, 40);
            this.rb3.Location = new System.Drawing.Point(10, 60);
            this.rb3.Checked = true;
            this.group_box.Controls.Add(rb1);
            this.group_box.Controls.Add(rb2);
            this.group_box.Controls.Add(rb3);
            






            // adds to form section
            this.Controls.Add(txt_box);
            this.Controls.Add(label_name);
            this.Controls.Add(bttn_one);
            this.Controls.Add(list_box1);
            this.Controls.Add(c_box1);
            this.Controls.Add(cb1);
            this.Controls.Add(cb2);
            this.Controls.Add(cb3);
            this.Controls.Add(group_box);

        }

        private void button_Click(object sender, EventArgs e)
        {
            String extras = "";
            bool salad = cb1.Checked;
            bool bread = cb2.Checked;
            bool wings = cb3.Checked;
            if (salad)
            {
                extras += cb1.Text + "\n";
            }
            if (bread)
            {
                extras += cb2.Text + "\n";
            }
            if (wings)
            {
                extras += cb3.Text + "\n";
            }

            String tip = "";
            bool ten = rb1.Checked;
            bool fifteen = rb2.Checked;
            bool twenty = rb3.Checked;
            if (ten)
            {
                tip = "10%";
            }
            else if (fifteen)
            {
                tip = "15%";
            }
            else
            {
                tip = "20%";
            }

            String crust = c_box1.SelectedItem.ToString();

            // single item selection
            //MessageBox.Show(txt_box.Text);
            //MessageBox.Show(crust);
            int index = list_box1.SelectedIndex;
            //MessageBox.Show((String)list_box1.Items[index]);
            
            // multiple item selection
            String selected = "";
            foreach (int item in list_box1.SelectedIndices)
            {
                selected += (String)list_box1.Items[item] + "\n";
            }
            MessageBox.Show("Order Name: " + txt_box.Text + "\n\n" + "Crust:\n" + crust + "\n\n" + "Toppings:\n"+ selected + "\n" +
                "Extras:\n" + extras + "\n" + "Tip:\n" + tip);
           
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
