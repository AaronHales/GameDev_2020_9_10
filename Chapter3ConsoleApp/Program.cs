using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Aaron"; // sets name variable to Aaron
            Console.WriteLine("Hello " + name); // writes Hello and name (variable)
            Console.WriteLine("Whats your last name?"); // writes line
            String last_name = Console.ReadLine(); // stores Console line as last_name
            Console.WriteLine("Welcome " + name + " " + last_name); // writes Welocme name (variable) last_name (variable)
            Console.ReadLine(); // waits for enter to be pressed
        }
    }
}
