using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator9_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double opperand1 = 0;
        double opperand2 = 0;
        String opperator = "";
        double answer;
        String text;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        public void radius_of_circle(object sender, RoutedEventArgs e)
        {
            double x = 0.0;
            double pi = Math.PI;
            double r = Double.Parse(screen.Text);
            x = pi * Math.Pow(r, 2);
            screen.Text = x.ToString();
        }

        private void num_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (screen.Text == "0") // if screen text equals 0 it will clear and continue to add, will also allow 0's, but no starting
            {
                text = "";

            }
            if (button.Content.Equals("e"))
            {
                text = Math.E.ToString();
            }
            else if (button.Content.Equals("π"))
            {
                text = Math.PI.ToString();
            }
            else
            {
                text += button.Content.ToString();
            }
            screen.Text = text;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = "0";
            opperand1 = 0;
            opperand2 = 0;
            opperator = "";
        }

        private void op_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            opperand1 = double.Parse(screen.Text);
            opperator = button.Content.ToString();
            screen.Text = "0";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            //double answer;
            opperand2 = double.Parse(screen.Text);
            if (opperator.Equals("+"))
            {
                answer = opperand1 + opperand2;
            }
            else if (opperator.Equals("-"))
            {
                answer = opperand1 - opperand2;
            }
            else if (opperator.Equals("×"))
            {
                answer = opperand1 * opperand2;
            }
            else if (opperator.Equals("/"))
            {
                if (opperand2 == 0)
                {
                    screen.Text = "Error";
                    MessageBox.Show("Error: Divided by 0");
                    MessageBox.Show("For you causing an inconvenience to the program, you will be forced to wait 5 seconds before continuing.");
                    System.Threading.Thread.Sleep(5000);
                    clear_Click(sender, e);
                }
                else
                {
                    answer = opperand1 / opperand2;
                }
            }
            else if (opperator.Equals("xⁿ"))
            {
                answer = Math.Pow(opperand1, opperand2);
            }
            else
            {
                MessageBox.Show("Why press enter when no data was entered.\nMath requires numbers");
                clear_Click(sender, e);
            }
            screen.Text = answer.ToString();
        }

        private void sqrt_root_Click(object sender, RoutedEventArgs e)
        {
            opperand1 = double.Parse(screen.Text);
            answer = Math.Sqrt(opperand1);
            screen.Text = answer.ToString();
        }

        private void squared_Click(object sender, RoutedEventArgs e)
        {
            opperand1 = double.Parse(screen.Text);
            answer = Math.Pow(opperand1, 2);
            screen.Text = answer.ToString();
        }

        private void pos_or_neg_Click(object sender, RoutedEventArgs e)
        {
            if (!screen.Text.Contains("-"))
            {
                text = "-" + text;
                screen.Text = text;
            }
            else
            {
                text = text.TrimStart('-');
                screen.Text = text;
            }
        }
    }
}
