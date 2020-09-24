using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventform
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            String first_name = first_name_txt.Text; // stores first name text box as first_name
            String middle_name = middle_name_txt.Text; // stores middle name text box as middle_name
            String last_name = last_name_txt.Text; // stores last name text box as middle_name
            first_name_lbl.Text = "First Name"; // changes lable text
            middle_name_lbl.Text = "Middle Name"; // changes lable text
            last_name_lbl.Text = "Last Name"; // changes lable text
            first_name_txt.Visible = true; // makes first name text box visible
            middle_name_txt.Visible = true; // makes middle name text box visible
            last_name_txt.Visible = true; // makes last name tex box visible
            MessageBox.Show("Welcome " + first_name + " " + middle_name + " " + last_name); // makes message box with entered first, middle, and last name

        }

        private void Main_Load(object sender, EventArgs e)
        {
            BackColor = Color.Aquamarine; // changes back color on load
        }

        private void middle_name_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("middle_name_txt lable clicked"); // creates message box
            BackColor = Color.Red; // changes main form back color
            MessageBox.Show("WHY YOU CLICK ME!"); // makes message bos
            MessageBox.Show("GO AWAY NOW!"); // makes message box
            Console.WriteLine("WHY YOU CLICK ME!"); // writes console line
            Console.WriteLine("GO AWAY NOW!"); // writes console line
            button1.BackColor = Color.Green; // changes button back color
            button1.Font = new Font("Microsoft Sans Serif", 20);
            first_name_lbl.Font = new Font("Microsoft Sans Serif", 30); // changes font
            middle_name_lbl.Font = new Font("Microsoft Sans Serif", 30); // changes font
            last_name_lbl.Font = new Font("Microsoft Sans Serif", 30); // changes font
            button1.Text = "EXIT"; // changes button text
            first_name_lbl.Text = "GO"; // changes lable text
            middle_name_lbl.Text = "AWAY"; // changes lable text
            last_name_lbl.Text = "NOW!"; // changes lable text
            first_name_txt.Visible = true; // makes first name text box visible
            middle_name_txt.Visible = true; // makes middle name text box visible
            last_name_txt.Visible = true; // makes last name tex box visible
        }

        private void first_name_txt_TextChanged(object sender, EventArgs e)
        {
            String first_name = first_name_txt.Text;
            String middle_name = middle_name_txt.Text;
            String last_name = last_name_txt.Text;
            Console.WriteLine(first_name);
            MessageBox.Show("first_name text changed");
        }

        private void first_name_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("middle_name_txt lable clicked"); // creates message box
            BackColor = Color.Red; // changes main form back color
            MessageBox.Show("WHY YOU CLICK ME!"); // makes message bos
            MessageBox.Show("GO AWAY NOW!"); // makes message box
            Console.WriteLine("WHY YOU CLICK ME!"); // writes console line
            Console.WriteLine("GO AWAY NOW!"); // writes console line
            button1.BackColor = Color.Green; // changes button back color
            button1.Font = new Font("Microsoft Sans Serif", 20);
            first_name_lbl.Font = new Font("Microsoft Sans Serif", 30); // changes font
            middle_name_lbl.Font = new Font("Microsoft Sans Serif", 30); // changes font
            last_name_lbl.Font = new Font("Microsoft Sans Serif", 30); // changes font
            button1.Text = "EXIT"; // changes button text
            first_name_lbl.Text = "GO"; // changes lable text
            middle_name_lbl.Text = "AWAY"; // changes lable text
            last_name_lbl.Text = "NOW!"; // changes lable text
            first_name_txt.Visible = true; // makes first name text box visible
            middle_name_txt.Visible = true; // makes middle name text box visible
            last_name_txt.Visible = true; // makes last name tex box visible
        }

        private void last_name_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("middle_name_txt lable clicked"); // creates message box
            BackColor = Color.Red; // changes main form back color
            MessageBox.Show("WHY YOU CLICK ME!"); // makes message bos
            MessageBox.Show("GO AWAY NOW!"); // makes message box
            Console.WriteLine("WHY YOU CLICK ME!"); // writes console line
            Console.WriteLine("GO AWAY NOW!"); // writes console line
            button1.BackColor = Color.Green; // changes button back color
            button1.Font = new Font("Microsoft Sans Serif", 20);
            first_name_lbl.Font = new Font("Microsoft Sans Serif", 30); // changes font
            middle_name_lbl.Font = new Font("Microsoft Sans Serif", 30); // changes font
            last_name_lbl.Font = new Font("Microsoft Sans Serif", 30); // changes font
            button1.Text = "EXIT"; // changes button text
            first_name_lbl.Text = "GO"; // changes lable text
            middle_name_lbl.Text = "AWAY"; // changes lable text
            last_name_lbl.Text = "NOW!"; // changes lable text
            first_name_txt.Visible = true; // makes first name text box visible
            middle_name_txt.Visible = true; // makes middle name text box visible
            last_name_txt.Visible = true; // makes last name tex box visible
        }

        private void last_name_txt_TextChanged(object sender, EventArgs e)
        {
            String last_name = last_name_txt.Text;
            Console.WriteLine(last_name);
            MessageBox.Show("last_name text changed");
        }

        private void middle_name_txt_TextChanged(object sender, EventArgs e)
        {
            String middle_name = middle_name_txt.Text;
            Console.WriteLine(middle_name);
            MessageBox.Show("middle_name text changed");
        }
    }
}
