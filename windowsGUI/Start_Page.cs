using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsGUI
{
    public partial class Start_Page : Form
    {
        public Start_Page()
        {
            InitializeComponent();
        }

        private void urser_age_spn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Start_page_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_age.BackColor = Color.Green;
            String name = user_name_txt.Text;
            Console.WriteLine(name);
            checkBox1.Visible = false;
            BackColor = Color.Yellow;
            String birthday = Convert.ToString(user_birthday_cal);
            Console.WriteLine(birthday);
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            
        }
    }
}
