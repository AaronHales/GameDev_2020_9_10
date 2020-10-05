using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Types
{
    public partial class data_types : Form
    {
        public data_types()
        {
            InitializeComponent();
        }

        private void numeric_button_Click(object sender, EventArgs e)
        {
            //  Create and initialize an integer variable
            int my_integer = 123;
            double my_double = 123.123;
            decimal my_decimal = -4567;
            float my_float = 3.2345F;

            //  Display the value of 'my_integer' in a Message Box
            // using  the 'ToString' method to convert the number to text
            MessageBox.Show("my_integer: " + my_integer.ToString());
            MessageBox.Show("my_double: " + my_double.ToString());
            MessageBox.Show("my_decimal: " + my_decimal.ToString());
            MessageBox.Show("my_float: " + my_float.ToString());
        }

        private void bool_button_Click(object sender, EventArgs e)
        {
            //  Create and initialize a boolean variable
            bool my_boolean = true;

            //  Display the value of 'my_boolean' in a Message Box
            // using  the 'ToString' method to convert the number to text
            MessageBox.Show("my_boolean: " + my_boolean.ToString());
        }

        private void constant_button_Click(object sender, EventArgs e)
        {
            //  Create and initialize a constant double variable
            const double PI = 3.14159;
            const int MY_INT = 42;

            //  Display the value of 'PI' in a Message Box
            // using  the 'ToString' method to convert the number to text
            MessageBox.Show("PI: " + PI.ToString());
            MessageBox.Show("MY_INT: " + MY_INT.ToString());
        }

        private void string_button_Click(object sender, EventArgs e)
        {
            //  Create and initialize an integer variable
            char my_char = 'A';
            String my_string = "this is a sting?";

            //  Display the value of 'my_char' in a Message Box
            // using  the 'ToString' method to convert the number to text
            MessageBox.Show("my_char: " + my_char);
            MessageBox.Show("my_string: " + my_string);
        }
    }
}
