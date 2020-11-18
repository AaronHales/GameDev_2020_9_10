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
        /*
        public void radius_of_circle(object sender, RoutedEventArgs e)
        {
            double x = 0.0;
            double pi = Math.PI;
            double r = Double.Parse(screen.Text);
            x = pi * Math.Pow(r, 2);
            screen.Text = x.ToString();
        }
        */

        private void num_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (screen.Text.StartsWith("0"))
            {
                screen.Text = "";                
            }
            if (button.Content.Equals("e"))
            {
                screen.Text = Math.E.ToString();
            }
            else if (button.Content.Equals("π"))
            {
                screen.Text = Math.PI.ToString();
            }
            else
            {
                screen.Text += button.Content.ToString();
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = "0";
            opperand1 = 0;
            opperand2 = 0;
            opperator = null;
            text = "";
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
            try
            {
                opperand2 = double.Parse(screen.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Something went wrong " + ex.Message);
            }
            if (opperator.Equals("+"))
            {
                try
                {
                    answer = opperand1 + opperand2;
                    screen.Text = answer.ToString();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Something went wrong " + ex.Message);
                }
            }
            else if (opperator.Equals("-"))
            {
                try
                {
                    answer = opperand1 - opperand2;
                    screen.Text = answer.ToString();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Something went wrong " + ex.Message);
                }
            }
            else if (opperator.Equals("×"))
            {
                try
                {
                    answer = opperand1 * opperand2;
                    screen.Text = answer.ToString();

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Something went wrong " + ex.Message);
                }
            }
            else if (opperator.Equals("÷"))
            {
                try
                {
                    if (opperand2 == 0)
                    {
                        MessageBox.Show("Error: Divided by 0");
                        MessageBox.Show("For causing an inconvenience to the program, you will be forced to wait 5 seconds before continuing.\n you will not be able to close the program.");
                        System.Threading.Thread.Sleep(5000);
                        clear_Click(sender, e);
                    }
                    else
                    {
                        answer = opperand1 / opperand2;
                        screen.Text = answer.ToString();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Something went wrong " + ex.Message);
                }
            }
            else if (opperator.Equals("xⁿ"))
            {
                try
                {
                    answer = Math.Pow(opperand1, opperand2);
                    screen.Text = answer.ToString();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Something went wrong " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Why press enter when no data was entered.\nMath requires numbers");
                clear_Click(sender, e);
            }
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
                screen.Text = "-" + screen.Text;
            }
            else
            {
                screen.Text = screen.Text.TrimStart('-');
            }
        }
    }
}
