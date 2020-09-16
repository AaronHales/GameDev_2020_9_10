using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
Aaron Hales
Hello World Example
CH 2.3
9/16/20
*/


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstVariable; // declaration statement

            myFirstVariable = "Welcome"; // assignment statment

            string Var2 = "something else";

            Console.WriteLine(myFirstVariable); // This is a console print statment.
            Console.WriteLine("Press any key to LEAVE"); // Lets the user know how to exit.
            Console.ReadKey(); // Read key presses.
            Console.WriteLine("no"); // This
            Console.ReadKey(); // Is
            Console.WriteLine("You can never leave"); // The
            Console.ReadKey(); // Way.
        }
    }
}
