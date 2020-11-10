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
        public int HEIGHT = 350;
        public Label lbl_name = new Label();
        public TextBox txt_box = new TextBox();
        public Button bttn = new Button();
        public Label lbl_equip = new Label();
        public ListBox list_box_equip = new ListBox();
        public Label lbl_vehicle = new Label();
        public ComboBox cb_vehicle = new ComboBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // setup form
            this.Size = new Size(WIDTH, HEIGHT);

            // setup label
            this.lbl_name.Size = new Size(130, 15);
            this.lbl_name.Location = new Point(WIDTH / 2 - 75, HEIGHT / 10 - 20);
            this.lbl_name.Text = "Enter player name:";

            // setup text box
            this.txt_box.Size = new Size(150, 50);
            this.txt_box.Location = new Point(WIDTH / 2 - 75, HEIGHT / 10 - 4);

            // setup label equipment
            this.lbl_equip.Size = new Size(130, 15);
            this.lbl_equip.Location = new Point(WIDTH / 2 - 75, HEIGHT / 5 + 10);
            this.lbl_equip.Text = "Select starting equipment:";

            // setup list box
            this.list_box_equip.Size = new Size(150, 75);
            this.list_box_equip.Location = new Point(WIDTH / 2 - 75, HEIGHT / 3 - 19);
            // adds items to list box
            list_box_equip.Items.Add("Utility Belt");
            list_box_equip.Items.Add("Rocket Boots");
            list_box_equip.Items.Add("Hockey Mask");
            list_box_equip.Items.Add("Rubber Ducky");

            // setup label vehicle
            this.lbl_vehicle.Size = new Size(130, 15);
            this.lbl_vehicle.Location = new Point(WIDTH / 2 - 75, HEIGHT / 2 + 10);
            this.lbl_vehicle.Text = "Select starting vehicle";

            // setup combo box vehicle
            this.cb_vehicle.Size = new Size(150, 50);
            this.cb_vehicle.Location = new Point(WIDTH / 2 - 75, HEIGHT / 2 + 25);
            // adds items to combo box
            cb_vehicle.Items.Add("Turbo Car");
            cb_vehicle.Items.Add("Space Plane");
            cb_vehicle.Items.Add("Stealth Sub");
            cb_vehicle.Items.Add("Pogo Stick");

            // setup button
            this.bttn.Size = new Size(150, 35);
            this.bttn.Location = new Point(WIDTH / 2 - 75, HEIGHT - 85);
            this.bttn.Text = "Start";
            this.bttn.Click += new EventHandler(button1_Click);

            

            // adds them to the form
            this.Controls.Add(lbl_name);
            this.Controls.Add(txt_box);
            this.Controls.Add(lbl_equip);
            this.Controls.Add(list_box_equip);
            this.Controls.Add(lbl_vehicle);
            this.Controls.Add(cb_vehicle);
            this.Controls.Add(bttn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "Player name is: " + txt_box.Text +
                "\nChosen equipment: " + list_box_equip.SelectedItem +
                "\nCchosen vehicle: " + cb_vehicle.SelectedItem;
            MessageBox.Show(message);

            txt_box.Text = "";
            list_box_equip.SelectedItem = -1;
            cb_vehicle.SelectedIndex = -1;
        }
    }
}
